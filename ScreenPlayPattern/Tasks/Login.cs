using Boa.Constrictor.Screenplay;
using Boa.Constrictor.WebDriver;
using ScreenPlayPattern.ComponentsUI;
using ScreenPlayPattern.Interactions;

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
            //actor.AttemptsTo(SendKeys.To(LoginComponent.UserInput, user));
            actor.AttemptsTo(Enter.TheValue(user).Into(LoginComponent.UserInput));
            actor.AttemptsTo(SendKeys.To(LoginComponent.PasswordInput, password));
            actor.AttemptsTo(Click.On(LoginComponent.LoginButton));
            
        }

        public static Login WithCredentials(string user, string password)
        {
            return new Login(user,password);
        }

        public static LoginBuilder WithUser(string user)
        {
            return new LoginBuilder(user);
        }
    }

    public class LoginBuilder{
        private string user;
        
        public LoginBuilder(string user)
        {
            this.user = user;
        }

        public Login AndPassword(string password)
        {
            return new Login(user, password);
        }

    } 
}
