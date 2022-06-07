namespace Serenity.Cinema {

  @Serenity.Decorators.registerClass()
  export class MoviecastEditDialog extends
    Serenity.Extensions.GridEditorDialog<MoviecastRow> {
    protected getFormKey() { return MoviecastForm.formKey; }
    protected getNameProperty() { return MoviecastRow.nameProperty; }
    protected getLocalTextPrefix() { return MoviecastRow.localTextPrefix; }

    protected form: MoviecastForm = new MoviecastForm(this.idPrefix);

    constructor() {
      super();
    }
  }
}