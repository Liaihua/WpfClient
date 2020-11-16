using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using WpfClient.Models;

namespace WpfClient.ViewModels
{
    class UsersViewModel
    {
        HttpClient httpClient;

        UsersViewModel()
        {
            httpClient = new HttpClient();
        }
        public async Task AddUserAsync(UserView user)
        {
            DataContractJsonSerializer dataContractJsonSerializer = new DataContractJsonSerializer(typeof(UserView));
            byte[] bytes = null;
            using (MemoryStream ms = new MemoryStream())
            {
                dataContractJsonSerializer.WriteObject(ms, new UserView { Fname = "имя ", Sname = "фамилия ", IdDepartmentNavigation = new DepartmentView { Id = 1 } });
                ms.Seek(0, SeekOrigin.Begin);

                bytes = new byte[ms.Length];
                ms.Read(bytes, 0, bytes.Length);
            }
            var content = new StringContent(Encoding.UTF8.GetString(bytes), Encoding.UTF8, "application/json");
            await httpClient.PostAsync("http://localhost:34396/api/users", content);

        }
    }
}
