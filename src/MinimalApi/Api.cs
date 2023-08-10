using DataAccess.Data;
using DataAccess.Models;

namespace MinimalApi
{
    public static class Api
    {
        public static void ConfigureApi(this WebApplication app)
        {
            app.MapGet("/Customers", GetCustomers);
            app.MapGet("/Customers/{id}", GetCustomer);
            app.MapPost("/Customers", InsertCustomer);
            app.MapPut("/Customers", UpdateCustomer);
            app.MapDelete("/Customers/{id}", DeleteCustomer);
        }

        private static async Task<IResult> GetCustomers(ICustomerData data)
        {
            try
            {
                return Results.Ok(await data.GetCustomers());
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> GetCustomer(int id, ICustomerData data)
        {
            try
            {
                return Results.Ok(await data.GetCustomer(id));
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> InsertCustomer(Customer customer, ICustomerData data)
        {
            try
            {
                await data.InsertCustomer(customer);
                return Results.Ok("Cliente inserido com sucesso!");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> UpdateCustomer(Customer customer, ICustomerData data)
        {
            try
            {
                await data.UpdateCustomer(customer);
                return Results.Ok("Cliente atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> DeleteCustomer(int id, ICustomerData data)
        {
            try
            {
                await data.Deleteustomer(id);
                return Results.Ok("Cliente deletado com sucesso!");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
