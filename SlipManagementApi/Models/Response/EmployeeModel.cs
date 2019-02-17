using Newtonsoft.Json;
using SlipManagementApi.Database.Tables;

namespace SlipManagementApi.Models.Response
{
    public class EmployeeModel
    {
        [JsonProperty("firstname")]
        public string FirstName { get; set; }

        [JsonProperty("lastname")]
        public string LastName { get; set; }

        [JsonProperty("age")]
        public ushort? Age { get; set; }

        public EmployeeModel(Employee employee)
        {
            FirstName = employee.FirstName;
            LastName = employee.LastName;
            Age = employee.Age;
        }
    }
}
