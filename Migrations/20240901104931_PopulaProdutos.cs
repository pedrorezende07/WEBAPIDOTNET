using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into apicatalogodb.products (CategorieId, Name,Description,Price,Url,Stock,RegistrationDate) VALUES " +
                "(1,'Coca-Cola','Descricao da coca-cola',5.00,'coca-cola.png', 10, now())");
            mb.Sql("Insert into apicatalogodb.products (CategorieId, Name,Description,Price,Url,Stock,RegistrationDate) VALUES " +
     "(2,'Pizza Calabresa','Pizza deliciosa com calabresa, cebola e azeitonas',35.90,'pizza-calabresa.png', 5, now())");

            mb.Sql("Insert into apicatalogodb.products (CategorieId, Name,Description,Price,Url,Stock,RegistrationDate) VALUES " +
                 "(3,'Suco de Laranja','Suco natural de laranja, 500ml',8.50,'suco-laranja.png', 20, now())");

            mb.Sql("Insert into apicatalogodb.products (CategorieId, Name,Description,Price,Url,Stock,RegistrationDate) VALUES " +
                 "(4,'Hambúrguer Clássico','Hambúrguer com carne, queijo, alface e tomate',22.00,'hamburguer-classico.png', 12, now())");

            mb.Sql("Insert into apicatalogodb.products (CategorieId, Name,Description,Price,Url,Stock,RegistrationDate) VALUES " +
                 "(5,'Notebook Gamer','Notebook potente para jogos',5999.90,'notebook-gamer.png', 3, now())");

            mb.Sql("Insert into apicatalogodb.products (CategorieId, Name,Description,Price,Url,Stock,RegistrationDate) VALUES " +
                 "(6,'Bola de Futebol','Bola de futebol oficial',89.90,'bola-futebol.png', 8, now())");

            mb.Sql("Insert into apicatalogodb.products (CategorieId, Name,Description,Price,Url,Stock,RegistrationDate) VALUES " +
                 "(7,'Smartphone XYZ','Smartphone moderno com câmera tripla',1499.00,'smartphone-xyz.png', 6, now())");

            mb.Sql("Insert into apicatalogodb.products (CategorieId, Name,Description,Price,Url,Stock,RegistrationDate) VALUES " +
                 "(8,'Camiseta Polo','Camiseta polo masculina, tamanho M',79.90,'camiseta-polo.png', 15, now())");
            // Bebidas
            mb.Sql("Insert into apicatalogodb.products (CategorieId, Name,Description,Price,Url,Stock,RegistrationDate) VALUES " +
                 "(1,'Água Mineral','Água mineral natural, 500ml',2.50,'agua-mineral.png', 30, now())");

            mb.Sql("Insert into apicatalogodb.products (CategorieId, Name,Description,Price,Url,Stock,RegistrationDate) VALUES " +
                 "(1,'Refrigerante Guaraná','Refrigerante de guaraná, 2 litros',7.90,'guarana.png', 15, now())");

            // Comidas
            mb.Sql("Insert into apicatalogodb.products (CategorieId, Name,Description,Price,Url,Stock,RegistrationDate) VALUES " +
                 "(2,'Lasanha à Bolonhesa','Lasanha caseira com molho à bolonhesa',42.50,'lasanha.png', 7, now())");

            mb.Sql("Insert into apicatalogodb.products (CategorieId, Name,Description,Price,Url,Stock,RegistrationDate) VALUES " +
                 "(2,'Salada Caesar','Salada com alface romana, frango grelhado e molho Caesar',18.90,'salada-caesar.png', 10, now())");

            // Bebidas
            mb.Sql("Insert into apicatalogodb.products (CategorieId, Name,Description,Price,Url,Stock,RegistrationDate) VALUES " +
                 "(3,'Chá Gelado de Limão','Chá gelado de limão, 1 litro',6.00,'cha-gelado-limao.png', 25, now())");

            mb.Sql("Insert into apicatalogodb.products (CategorieId, Name,Description,Price,Url,Stock,RegistrationDate) VALUES " +
                 "(3,'Café Expresso','Café expresso tradicional',4.50,'cafe-expresso.png', 30, now())");

            // Comidas
            mb.Sql("Insert into apicatalogodb.products (CategorieId, Name,Description,Price,Url,Stock,RegistrationDate) VALUES " +
                 "(4,'Macarrão à Carbonara','Macarrão com molho carbonara e bacon',28.00,'macarrao-carbonara.png', 9, now())");

            mb.Sql("Insert into apicatalogodb.products (CategorieId, Name,Description,Price,Url,Stock,RegistrationDate) VALUES " +
                 "(4,'Sanduíche Natural','Sanduíche com pão integral, peito de peru e queijo branco',12.50,'sanduiche-natural.png', 18, now())");

            // Informática
            mb.Sql("Insert into apicatalogodb.products (CategorieId, Name,Description,Price,Url,Stock,RegistrationDate) VALUES " +
                 "(5,'Monitor 24 polegadas','Monitor Full HD de 24 polegadas',899.00,'monitor-24.png', 5, now())");

            mb.Sql("Insert into apicatalogodb.products (CategorieId, Name,Description,Price,Url,Stock,RegistrationDate) VALUES " +
                 "(5,'Mouse sem fio','Mouse sem fio ergonômico',69.90,'mouse-sem-fio.png', 12, now())");

            // Esporte
            mb.Sql("Insert into apicatalogodb.products (CategorieId, Name,Description,Price,Url,Stock,RegistrationDate) VALUES " +
                 "(6,'Raquete de Tênis','Raquete de tênis profissional',349.90,'raquete-tenis.png', 2, now())");

            mb.Sql("Insert into apicatalogodb.products (CategorieId, Name,Description,Price,Url,Stock,RegistrationDate) VALUES " +
                 "(6,'Tênis de Corrida','Tênis de corrida com amortecimento',299.00,'tenis-corrida.png', 7, now())");

            // Telefonia
            mb.Sql("Insert into apicatalogodb.products (CategorieId, Name,Description,Price,Url,Stock,RegistrationDate) VALUES " +
                 "(7,'Fone de Ouvido Bluetooth','Fone de ouvido sem fio com ótima qualidade de som',199.00,'fone-bluetooth.png', 10, now())");

            mb.Sql("Insert into apicatalogodb.products (CategorieId, Name,Description,Price,Url,Stock,RegistrationDate) VALUES " +
                 "(7,'Capa para Celular','Capa protetora para celular',49.90,'capa-celular.png', 20, now())");

            // Moda
            mb.Sql("Insert into apicatalogodb.products (CategorieId, Name,Description,Price,Url,Stock,RegistrationDate) VALUES " +
                 "(8,'Calça Jeans','Calça jeans feminina, tamanho 38',129.90,'calca-jeans.png', 8, now())");

            mb.Sql("Insert into apicatalogodb.products (CategorieId, Name,Description,Price,Url,Stock,RegistrationDate) VALUES " +
                 "(8,'Vestido de Festa','Vestido longo para festas',249.00,'vestido-festa.png', 3, now())");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {

        }
    }
}
