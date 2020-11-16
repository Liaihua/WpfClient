using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using WpfClient.Models;

namespace WpfClient.ViewModels
{
    class DepartmentsViewModel
    {
        HttpClient httpClient;
        DepartmentsViewModel()
        {
            httpClient = new HttpClient();
        }
        async Task<List<DepartmentView>> ReadDepartmentsList()
        {
            List<DepartmentView> result = null;
            var responce = await httpClient.GetAsync("http://loclahost:34396/api/departments");
            DataContractJsonSerializer dataContractJsonSerializer = new DataContractJsonSerializer(typeof(List<DepartmentView>));
            using (var answerStream = await responce.Content.ReadAsStreamAsync())
            {
                result = (List<DepartmentView>)dataContractJsonSerializer.ReadObject(answerStream);
            }
            return result;
        }

        async Task AddDepartment(DepartmentView department)
        {

            return null;
        }
    }
}
