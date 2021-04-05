namespace BattleNotifications.Contracts.EmailTemplates
{
    public class NewAccountTemplates
    {
        public const string Html = @"<!DOCTYPE html>
        <html lang=""en"">
            <head>
                <meta charset = ""UTF-8"" />
                    < meta http-equiv=""X-UA-Compatible"" content=""IE=edge"" />
                <meta name = ""viewport"" content=""width=device-width, initial-scale=1.0"" />
                <title>Welcome to BattleLine</title>
            </head>
            <body>
                <h1 style = ""text-align: center"" >
                    < strong > Welcome to your new Battleline Account!</strong>
                </h1>
                <p style = ""text-align: center"" >
                           Now that you are registered you can use cool features of our site and
                    applications:
                </p>
                <ul>
                <li style = ""text-align: center"" > Check out our Forums!</li>
                <li style = ""text-align: center"" >
                            Use our Smart List App to create lists!
                </li>
                <li style = ""text-align: center"" > Play any of our games!</li>
                <li style = ""text-align: center"" > Get to know us!</li>
                </ul>
            </body>
        </html>";

        public const string PlainText = @"Welcome to your new Battleline Account! \n Now that you are registered you can use cool features of our site and
            applications";
    }
}