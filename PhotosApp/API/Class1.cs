using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data.Entity.Migrations;
using System.Data.Entity;
using PhotosApp;

namespace PhotosApp
{
    
    public class Class1
    {
        public static void addDetails(String path, String locatie, String anotimp, DateTime data, String[] persoane)
        {
            if (checkPath(path) == true)
            {
                using (Model1Container context = new Model1Container())
                {
                    Photo aux = new Photo()
                    {
                        Path = path,
                        Locatie = locatie,
                        Anotimp = anotimp,
                        Data = data
                    };


                    context.Photos.Add(aux);
                    context.SaveChanges();
                    for (int i = 0; i < persoane.Length; i++)
                    {
                        Person p = new Person()
                        {
                            Nume = persoane[i],
                            Photo = aux
                        };
                        context.People.Add(p);
                    }


                    context.SaveChanges();
                }
            }

        }

        public static bool checkPath(String path)
        {
           
            using (Model1Container context = new Model1Container())
            {
                var items = context.Photos
                            .Where(b => b.Path == path)
                            .FirstOrDefault();
                if (items == null)
                    return true;
               
            }

            return false;
        }

        public static void insertNewImage(String path, String locatie, String anotimp, DateTime data, String[] persoane)
        {
            if (checkPath(path) == true)
            {
                using (Model1Container context = new Model1Container())
                {
                    Photo aux = new Photo()
                    {
                        Path = path,
                        Locatie = locatie,
                        Anotimp = anotimp,
                        Data = DateTime.Now
                        
                    };


                    context.Photos.Add(aux);
                    context.SaveChanges();
                    for (int i = 0; i < persoane.Length; i++)
                    {
                        Person p = new Person()
                        {
                            Nume = persoane[i],
                            Photo = aux
                        };
                        context.People.Add(p);
                    }


                    context.SaveChanges();
                }
            }

        }


        public static void updateDetails(String path, String locatie, String anotimp, DateTime data, String[] persoane)
        {
            using (Model1Container context = new Model1Container())
            {
                
                var result = context.Photos.SingleOrDefault(b => b.Path == path);
                
                if(result != null)
                {
                    result.Locatie = locatie;
                    result.Anotimp = anotimp;
                    result.Data = data;                   
      
                }
                
                context.People.RemoveRange(context.People.Where(x => x.PhotoId == result.Id));

                for (int i = 0; i < persoane.Length; i++)
                {
                    Person p = new Person()
                    {
                        Nume = persoane[i],
                        Photo = result
                    };
                    context.People.AddOrUpdate(p);


                }

                context.SaveChanges();
               
            }
        }

        public static void deleteDetails(String path)
        {
            using (Model1Container context = new Model1Container())
            {

                var result = context.Photos.SingleOrDefault(b => b.Path == path);

                if (result != null)
                {
                    context.People.RemoveRange(context.People.Where(x => x.PhotoId == result.Id));
                    context.Photos.RemoveRange(context.Photos.Where(x => x.Path == path));
                }
                context.SaveChanges();


            }
           
        }
        public static List<String> getDetails(String path)
        {
            using (Model1Container context = new Model1Container())
            {
                var photo = (from s in context.Photos
                join sa in context.People on s.Id equals sa.PhotoId
                             where s.Path == path
                select s).ToList();

                List<string> photos = new List<string>();
                string aux = "";
                foreach(var items in photo)
                {
                    photos.Add(items.Path);
                    photos.Add(items.Locatie);
                    photos.Add(items.Anotimp);
                    photos.Add(Convert.ToString(items.Data));
                    foreach (var x in items.People)
                        aux += " " + x.Nume;
                    photos.Add(aux);
                }
                return photos;
                
            }
           
            
        }

        public static List<String> getPaths(String search)
        {
            using (Model1Container context = new Model1Container())
            {
                var photo = (from s in context.Photos
                             join sa in context.People on s.Id equals sa.PhotoId
                             where s.Anotimp == search || s.Locatie == search || sa.Nume == search
                             select s.Path).ToList();

                List<string> paths = new List<string>();
                
                foreach (var items in photo)
                {
                    paths.Add(items);
                }
                return paths;

            }
        }

    }
}
