namespace Serenity.Membership {
    export interface ResetPasswordForm {
        NewPassword: PasswordEditor;
        ConfirmPassword: PasswordEditor;
    }

    export class ResetPasswordForm extends Serenity.PrefixedContext {
        static formKey = 'Membership.ResetPassword';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ResetPasswordForm.init)  {
                ResetPasswordForm.init = true;

                var s = Serenity;
                var w0 = PasswordEditor;

                Q.initFormType(ResetPasswordForm, [
                    'NewPassword', w0,
                    'ConfirmPassword', w0
                ]);
            }
        }
    }
}
