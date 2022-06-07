namespace Serenity.Cinema {
  @Serenity.Decorators.registerFormatter()
  export class GenreListFormatter implements Slick.Formatter {
    format(ctx: Slick.FormatterContext) {
      let idList = ctx.value as number[];
      if (!idList || !idList.length)
        return "";

      var byId = GenreRow.getLookup().itemById;

      return idList.map(x => {
        let g = byId[x];
        if (!g)
          return x.toString();

        return Q.htmlEncode(g.Name);
      }).join(", ");
    }
  }
}