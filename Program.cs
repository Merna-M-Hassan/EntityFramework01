using Assignment_24_EF_Core.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Assignment_24_EF_Core
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using BookInventoryDbContext dbCoantext = new BookInventoryDbContext();   //Opens connection with DB.
            //Database Connection: is unmanaged resource. --> CLR will not deal with dbcontext in heap. 

            //await dbCoantext.Database.MigrateAsync();    //Auto apply any pending migration in DB.  Executes once run the application and open connection with DB.
            //MigrateAsync() --> because it is a heavy operation. --> deal with external DB.

            

            //try
            //{
            //}
            //catch(Exception ex) 
            //{            
            //}
            //finally
            //{
            //    dbContext.Dispose();
            //    //Dispose: will make two things:
            //    // - Deallocate context object from heap (remove/delete from heap).
            //    // - Once the object is removed from heap, the connection will close.
            //}


            //using BookInventoryDbContext dbContext = new BookInventoryDbContext()
            //{

            //};
        }
    }
}
