using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ClinicaOdontologica.Consumer
{
    public class CRUD<T>
    {
        public static string Endpoint { get; set; }

        public static List<T> GetAll()
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(Endpoint).Result;
                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<List<T>>(json);
                }
                else
                {
                    throw new Exception($"Error al obtener los datos: {response.ReasonPhrase}");
                }
            }
        }

        public static T GetValue(int id)
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync($"{Endpoint}/{id}").Result;
                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<T>(json);
                }
                else
                {
                    throw new Exception($"Error al obtener el dato: {response.ReasonPhrase}");
                }
            }
        }

        public static T Create(T item)
        {
            using (var client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(item);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = client.PostAsync(Endpoint, content).Result;
                if (response.IsSuccessStatusCode)
                {
                    var responseJson = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<T>(responseJson);
                }
                else
                {
                    throw new Exception($"Error al crear el dato: {response.ReasonPhrase}");
                }
            }
        }

        public static bool Update(int id, T item)
        {
            using (var client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(item);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = client.PutAsync($"{Endpoint}/{id}", content).Result;

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception($"Error al actualizar el dato: {response.ReasonPhrase}");
                }
            }
        }
    }
}
