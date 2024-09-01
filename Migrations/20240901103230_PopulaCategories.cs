using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb )
        {
            mb.Sql("Insert into apicatalogodb.categories (Name,Url) VALUES ('Bebida','Bebibda.png')");
            mb.Sql("Insert into apicatalogodb.categories (Name,Url) VALUES ('Comida','Comida.png')");
            mb.Sql("Insert into apicatalogodb.categories (Name,Url) VALUES ('Informática','Informática.png')");
            mb.Sql("Insert into apicatalogodb.categories (Name,Url) VALUES ('Esporte','Esporte.png')");
            mb.Sql("Insert into apicatalogodb.categories (Name,Url) VALUES ('Telefonia','Telefonia.png')");
            mb.Sql("Insert into apicatalogodb.categories (Name,Url) VALUES ('Moda','Moda.png')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
        }
    }
}
