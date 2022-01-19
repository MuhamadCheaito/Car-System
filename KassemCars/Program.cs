using CSM_Project;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KassemCars
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppDomain.CurrentDomain.SetData("DataDirectory", Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            //updatePurchaseCars();
            Application.Run(new frmLogin());
        }
        //static void updatePurchaseCars()
        //{
        //    try
        //    {
        //        RedundantData.con.Open();
        //        string carUpdateQuery = @"UPDATE CAR
        //                                SET COMPANY='OLD' WHERE  PurchaseDate < DATEADD(m, -3, GETDATE())";
        //        SqlCommand carUpdateCMD = new SqlCommand(carUpdateQuery, RedundantData.con);
        //        carUpdateCMD.ExecuteNonQuery();
        //        string carDateQuery = @"UPDATE CAR
        //                             SET COMPANY='NEW' WHERE  PurchaseDate > DATEADD(m, -3, GETDATE())";
        //        SqlCommand carDateCMD = new SqlCommand(carDateQuery, RedundantData.con);
        //        carDateCMD.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {

        //        CustomMsgBox.Show(ex.Message, "OK");
        //    }
        //    finally
        //    {
        //        RedundantData.con.Close();
        //    }
        //}
    }
}
