namespace Serenity.Membership {
    export interface SignUpForm {
        DisplayName: StringEditor;
        Email: EmailAddressEditor;
        ConfirmEmail: EmailAddressEditor;
        Password: PasswordEditor;
        ConfirmPassword: PasswordEditor;
    }

    export class SignUpForm extends Serenity.PrefixedContext {
        static formKey = 'Membership.SignUp';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!SignUpForm.init)  {
                SignUpForm.init = true;

                var s = Serenity;
                var w0 = StringEditor;
                var w1 = EmailAddressEditor;
                var w2 = PasswordEditor;

                Q.initFormType(SignUpForm, [
                    'DisplayName', w0,
                    'Email', w1,
                    'ConfirmEmail', w1,
                    'Password', w2,
                    'ConfirmPassword', w2
                ]);
            }
        }
    }
}
