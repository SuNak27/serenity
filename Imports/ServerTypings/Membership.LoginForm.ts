namespace Serenity.Membership {
    export interface LoginForm {
        Username: StringEditor;
        Password: PasswordEditor;
    }

    export class LoginForm extends Serenity.PrefixedContext {
        static formKey = 'Membership.Login';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!LoginForm.init)  {
                LoginForm.init = true;

                var s = Serenity;
                var w0 = StringEditor;
                var w1 = PasswordEditor;

                Q.initFormType(LoginForm, [
                    'Username', w0,
                    'Password', w1
                ]);
            }
        }
    }
}
