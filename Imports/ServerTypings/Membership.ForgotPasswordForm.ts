namespace Serenity.Membership {
    export interface ForgotPasswordForm {
        Email: EmailAddressEditor;
    }

    export class ForgotPasswordForm extends Serenity.PrefixedContext {
        static formKey = 'Membership.ForgotPassword';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ForgotPasswordForm.init)  {
                ForgotPasswordForm.init = true;

                var s = Serenity;
                var w0 = EmailAddressEditor;

                Q.initFormType(ForgotPasswordForm, [
                    'Email', w0
                ]);
            }
        }
    }
}
