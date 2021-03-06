namespace BattleNotifications.Contracts.EmailTemplates
{
    public class ForgotPasswordTemplates
    {
        public string Html { get; } = @"<!DOCTYPE html>
        <html lang=""en"">
            <head>
                <meta charset=""UTF-8""/>
                <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"" />
                <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
                <title>Forgot your password?</title>
            </head>
            <body>
                <h1 style=""text-align: center"" >
                    <strong> Oh No! You've forgotten your Battleline password?<br /></strong>
                </h1>
                <p style=""text-align: center"" >
                           Thats okay! We can help you with that!
                <a href=""{{ResetLink}}""> Click Here</a> to complete your password reset.
            
                </p>
                <p style=""text-align: center"" >
                           But what if you didn't request this? Please
                    <a href=""{{NotRequestedLink}}""> Click Here</a> to let us know something went
                wrong!
                </p>
            </body> 
        </html>";

        public string PlainText { get; } = @"Oh No! You've forgotten your Battleline password? \n Thats okay! We can help you with that! \n 
Click Here to complete your password reset : {{ResetLink}} \n But what if you didn't request this? Please Click here to let us known something went wrong: {{NotRequestedLink}} ";

        public string Subject { get; } = @"Battleline Password Recovery";

    }
}