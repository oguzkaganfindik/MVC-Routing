namespace MVC_Routing.Models
{
    //VM => ViewModel
    public class UserInfoVM
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string InformationText { get; set; }
        public List<string> Roles { get; set; }
    }
}
