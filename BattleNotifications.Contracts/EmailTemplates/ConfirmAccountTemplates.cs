namespace BattleNotifications.Contracts.EmailTemplates
{
    public class ConfirmAccountTemplates
    {
        public string Html { get; } = @"<!DOCTYPE html>
        <html lang=""en"">
            <head>
                <meta charset = ""UTF-8"" />
                    < meta http-equiv=""X-UA-Compatible"" content=""IE=edge"" />
                <meta name = ""viewport"" content=""width=device-width, initial-scale=1.0"" />
                <title>New Account!</title>
            </head>
                <body>
                <h1 style = ""text-align: center"" >
                    < strong > YAY! You've Created an account with Us!</strong>
                </h1>
                <p style = ""text-align: center"" >
                           Now we can take the next steps of validating your account.Please use the
                code below to validate your account:
                </p>
                <p style = ""text-align: center"" >{{Code}}</p>
            </body>
        </html>";

        public string PlainText { get; } = @"YAY! You've Created an account with Us!\n Now we can take the next steps of validating your account.Please use the
        code below to validate your account: {{Code}}";

        public string Subject { get; } = @"Confirm your Battleline Account!";

    }
}