namespace Serenity.Cinema {
  @Serenity.Decorators.registerEditor()
  export class MoviecastEditor extends Serenity.Extensions.GridEditorBase<MoviecastRow> {
    protected getColumnsKey() { return "Cinema.Moviecast"; }
    protected getDialogType() { return MoviecastEditDialog; }
    protected getLocalTextPrefix() { return MoviecastRow.localTextPrefix; }

    constructor(container: JQuery) {
      super(container);
    }

    protected getAddButtonCaption() {
      return "Add"
    }

    protected validateEntity(row: MoviecastRow, id: number) {
      if (!super.validateEntity(row, id))
        return false;

      row.PersonFullname = PersonRow.getLookup()
        .itemById[row.PersonId].Fullname;

      return true;
    }
  }
} 