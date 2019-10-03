namespace MarinaIvanna.Models
{
    public class UserRequest
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Message { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Company { get; set; }
        public string Status { get; set; }
        public string ManagerName { get; set; }

        public UserRequest(int id, string mes, string em, string name, string address, string company, string status)
        {
            Id = id;
            Message = mes;
            Email = em;
            Name = name;
            Address = address;
            Company = company;
            Status = status;
        }

        public UserRequest()
        {
            Message = "";
            Email = "";
            Name = "";
            Address = "";
            Company = "";
        }
    }
}