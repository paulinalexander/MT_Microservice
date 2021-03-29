using Microsoft.EntityFrameworkCore;
using MT.OnlineRestaurant.DataLayer.Context;
using MT.OnlineRestaurant.DataLayer.interfaces;
using System.Data.SqlClient;
using System.Text;

namespace MT.OnlineRestaurant.DataLayer
{
    public class PaymentDbAccess : IPaymentDbAccess
    {
        private readonly OrderManagementContext _context;

        public PaymentDbAccess(OrderManagementContext context)
        {
            _context = context;
        }

        public int MakePaymentForOrder(TblOrderPayment orderPaymentDetails)
        {
            _context.TblOrderPayment.Add(orderPaymentDetails);
            _context.SaveChanges();
            return orderPaymentDetails.Id;
        }

        public int UpdatePaymentAndOrderStatus(TblOrderPayment orderPaymentDetails)
        {
            var ID = new SqlParameter
            {
                ParameterName = "@ID",
                DbType = System.Data.DbType.Int32,
                Value = orderPaymentDetails.Id,
                Direction = System.Data.ParameterDirection.Input
            };
            var TransactionID = new SqlParameter
            {
                ParameterName = "@TransactionID",
                DbType = System.Data.DbType.String,
                Size = 20,
                Value = orderPaymentDetails.TransactionId,
                Direction = System.Data.ParameterDirection.Input
            };
            var tblPaymentStatusID = new SqlParameter
            {
                ParameterName = "@tblPaymentStatusID",
                DbType = System.Data.DbType.Int32,
                Value = orderPaymentDetails.TblPaymentStatusId,
                Direction = System.Data.ParameterDirection.Input
            };
            var ReturnValue = new SqlParameter
            {
                ParameterName = "@ReturnValue",
                DbType = System.Data.DbType.Int32,
                Direction = System.Data.ParameterDirection.Output
            };


            _context.Database.ExecuteSqlInterpolated($"exec UpdatePaymentStatus @ID={ID}, @TransactionID={TransactionID},@tblPaymentStatusID={tblPaymentStatusID}, @ReturnValue OUT={ReturnValue}");

            _context.SaveChanges();
            return (int)ReturnValue.Value;
        }
    }
}
