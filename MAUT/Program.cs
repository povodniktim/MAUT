using MAUT.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Syncfusion.Blazor;

namespace MAUT
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();

            // Add services to the container.
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt+QHJqVk1mQ1BFaV1CX2BZdll3RmlZfE4BCV5EYF5SRHNeQF1qSHhQcU1mWH4=;Mgo+DSMBPh8sVXJ1S0R+X1pCaV5DQmFJfFBmTWlYfFRwd0U3HVdTRHRcQlhiS35ad0NgXndZcnU=;ORg4AjUWIQA/Gnt2VFhiQlJPcEBDXHxLflF1VWtTfl16dFZWESFaRnZdQV1mSHxTf0RlWnhXcnxU;MjAyMjMxMEAzMjMxMmUzMjJlMzNaT0UzTlpneVN4SklWd2JZZXRFUzNyaGwyT3RHS25oeEIzUEhLdDZXNi9jPQ==;MjAyMjMxMUAzMjMxMmUzMjJlMzNpMFp0R2VqNGhGWWQyYWxmaWt2Z0JLc09mRkZTWUtxSGpxUEZaMVhxYXU4PQ==;NRAiBiAaIQQuGjN/V0d+Xk9HfVldXGJWfFN0RnNRdV9zflVFcC0sT3RfQF5jTH9RdkxiX3xWcXFQRw==;MjAyMjMxM0AzMjMxMmUzMjJlMzNjSElCTmI5QnNZVk5SRWJ6TGxWKzBXTDRpQmMxODhsMTJyQW1JMGRJK0M0PQ==;MjAyMjMxNEAzMjMxMmUzMjJlMzNGbW5JMWlGanVDL3VJS29QQmk2V3NQTnIyUXlodTJHaEZMMmF4akIrQ29RPQ==;Mgo+DSMBMAY9C3t2VFhiQlJPcEBDXHxLflF1VWtTfl16dFZWESFaRnZdQV1mSHxTf0RlWnddeHxU;MjAyMjMxNkAzMjMxMmUzMjJlMzNFWWpkR0hnMUV3a2s0UVlVSE8vdjBSQUVDVTBrNG54d0ZUWXhuOHZ6ajg4PQ==;MjAyMjMxN0AzMjMxMmUzMjJlMzNMY0NuMUw2dDlqNFdnSFFRUVpnMHA0d2IvMVNINFpYOERiT0V6aWd3ejdzPQ==;MjAyMjMxOEAzMjMxMmUzMjJlMzNjSElCTmI5QnNZVk5SRWJ6TGxWKzBXTDRpQmMxODhsMTJyQW1JMGRJK0M0PQ==");
            builder.Services.AddSyncfusionBlazor();
            
            builder.Services.AddSingleton<DataModel>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");

            app.Run();
        }
    }
}