
namespace Serenity.Cinema {

    @Serenity.Decorators.registerClass()
    export class MoviecastDialog extends Serenity.EntityDialog<MoviecastRow, any> {
        protected getFormKey() { return MoviecastForm.formKey; }
        protected getIdProperty() { return MoviecastRow.idProperty; }
        protected getLocalTextPrefix() { return MoviecastRow.localTextPrefix; }
        protected getNameProperty() { return MoviecastRow.nameProperty; }
        protected getService() { return MoviecastService.baseUrl; }
        protected getDeletePermission() { return MoviecastRow.deletePermission; }
        protected getInsertPermission() { return MoviecastRow.insertPermission; }
        protected getUpdatePermission() { return MoviecastRow.updatePermission; }

        protected form = new MoviecastForm(this.idPrefix);

    }
}