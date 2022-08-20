// using System.Data.SqlClient;
// using GP.ECommerce1.Temp.Infrastructure.Sql.DataGenerator.Entities;
// using GP.Utilix;
//
// namespace GP.ECommerce1.Temp.Infrastructure.Sql.DataGenerator;
//
// public class SeedCategories
// {
//     public void Seed(int parents, int children)
//     {
//         var connection =
//             new SqlConnection(
//                 "Server=DESKTOP-9FJ5CB1\\SQLEXPRESS;Database=GP.ECommerce1.Temp;Trusted_Connection=True;MultipleActiveResultSets=true");
//
//         for (int i = 1; i <= parents; i++)
//         {
//             var category = new Category {Name = Randoms.RandomString(5)};
//             // var cmd = new SqlCommand();
//         }
//     }
// }