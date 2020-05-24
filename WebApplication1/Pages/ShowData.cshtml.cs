using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReference1;
using WebApplication1.Models;
using WebApplication1.Pages;
using System.Text.RegularExpressions;
using Grpc.Core;

namespace WebApplication1.Pages
{
    public class ShowDataModel : PageModel
    {
        
        InterfacePhotosAppClient pcc = new InterfacePhotosAppClient();
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public static int aparitii { get; set; }
        public List<DetailsDTO> Details { get; set; }

        public ShowDataModel()
        {
            Details = new List<DetailsDTO>();
        }

        public async Task OnGetAsync()
        {
            string aux1 = "";           
            var posts = await pcc.getAllDetailsAsync();
            int ok = 1;
            DetailsDTO pd = new DetailsDTO();
            aparitii = posts.Count / 5;
            foreach (var item in posts)
            {
                //Console.WriteLine(item);
                if (ok == 1)
                {
                    string aux = item.Replace('\\', '/');
                    string[] words = aux.Split('/');                    
                    pd.Path = '/' + words[8]+ '/' + words[9];
                }
                else if (ok == 2)
                    pd.Locatie = item;
                else if (ok == 3)
                    pd.Anotimp = item;
                else if (ok == 4)
                    pd.Data = item;
                else if (ok == 5)
                {
                    if (aux1 == "")
                    {
                        pd.People = item;                        
                        Details.Add(pd);
                        ok = 0;
                        aux1 = item;
                    }
                    else
                    {
                        int k1 = aux1.Length;
                        string after = item.Remove(0, k1);                        
                        pd.People = after;
                        Details.Add(pd);
                        ok = 0;
                        aux1 = item;
                    }
                    pd = new DetailsDTO();
                }
                ok++;
            }

            
            if (!string.IsNullOrEmpty(SearchString))
            {
                Details.Clear();
                ok = 1;
                pd = new DetailsDTO();
                var search_result = await pcc.getPathsAsync(SearchString);
                aparitii = search_result.Count;
                //Console.WriteLine(search_result.Count);
                foreach (var item in search_result)
                {
                    var details = await pcc.getDetailsAsync(item);
                    foreach (var item2 in details)
                    {  
                        if (ok == 1)
                        {
                            string aux = item.Replace('\\', '/');
                            string[] words = aux.Split('/');
                            pd.Path = '/' + words[8] + '/' + words[9];
                            
                        }
                        else if (ok == 2)
                            pd.Locatie = item2;
                        else if (ok == 3)
                            pd.Anotimp = item2;
                        else if (ok == 4)
                            pd.Data = item2;
                        else if (ok == 5)
                        {
                            pd.People = item2;
                            Details.Add(pd);
                            ok = 0;
                            pd = new DetailsDTO();
                        }
                        ok++;
                    }
                }
               
            }
        }

    }
}