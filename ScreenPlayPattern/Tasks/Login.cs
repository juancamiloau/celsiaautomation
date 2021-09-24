using Boa.Constrictor.Screenplay;
using Boa.Constrictor.WebDriver;
using ScreenPlayPattern.ComponentsUI;

namespace ScreenPlayPattern.Tasks
{
    public class Login : ITask
    {

        private readonly string user;
        private readonly string password;

        public Login(string user, string password)
        {
            this.user = user;
            this.password = password;
        }

        public void PerformAs(IActor actor)
        {
            actor.AttemptsTo(SendKeys.To(LoginComponent.UserInput, user));
            actor.AttemptsTo(SendKeys.To(LoginComponent.PasswordInput, password));
            actor.AttemptsTo(Click.On(LoginComponent.LoginButton));
        }

        public static Login WithCredentials(string user, string password)
        {
            return new Login(user,password);
        }
    }
}
