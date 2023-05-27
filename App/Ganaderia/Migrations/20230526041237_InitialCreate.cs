using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ganaderia.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "direccion",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_direccion", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "genero",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_genero", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "rango_de_peso",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rangodepeso = table.Column<string>(name: "rango_de_peso", type: "nvarchar(255)", maxLength: 255, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rango_de_peso", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "raza",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_raza", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "finca",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    idubicacion = table.Column<int>(name: "id_ubicacion", type: "int", nullable: false),
                    estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_finca", x => x.id);
                    table.ForeignKey(
                        name: "FK_finca_direccion_id_ubicacion",
                        column: x => x.idubicacion,
                        principalTable: "direccion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "corral",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idgenero = table.Column<int>(name: "id_genero", type: "int", nullable: false),
                    idrangopeso = table.Column<int>(name: "id_rango_peso", type: "int", nullable: false),
                    idfinca = table.Column<int>(name: "id_finca", type: "int", nullable: false),
                    numerocorral = table.Column<int>(name: "numero_corral", type: "int", nullable: false),
                    cantidadcorral = table.Column<int>(name: "cantidad_corral", type: "int", nullable: false),
                    cantidadactual = table.Column<int>(name: "cantidad_actual", type: "int", nullable: false),
                    estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_corral", x => x.id);
                    table.ForeignKey(
                        name: "FK_corral_finca_id_finca",
                        column: x => x.idfinca,
                        principalTable: "finca",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_corral_genero_id_genero",
                        column: x => x.idgenero,
                        principalTable: "genero",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_corral_rango_de_peso_id_rango_peso",
                        column: x => x.idrangopeso,
                        principalTable: "rango_de_peso",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "animal",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idraza = table.Column<int>(name: "id_raza", type: "int", nullable: false),
                    idcorral = table.Column<int>(name: "id_corral", type: "int", nullable: false),
                    estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_animal", x => x.id);
                    table.ForeignKey(
                        name: "FK_animal_corral_id_corral",
                        column: x => x.idcorral,
                        principalTable: "corral",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_animal_raza_id_raza",
                        column: x => x.idraza,
                        principalTable: "raza",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_animal_id_corral",
                table: "animal",
                column: "id_corral");

            migrationBuilder.CreateIndex(
                name: "IX_animal_id_raza",
                table: "animal",
                column: "id_raza");

            migrationBuilder.CreateIndex(
                name: "IX_corral_id_finca",
                table: "corral",
                column: "id_finca");

            migrationBuilder.CreateIndex(
                name: "IX_corral_id_genero",
                table: "corral",
                column: "id_genero");

            migrationBuilder.CreateIndex(
                name: "IX_corral_id_rango_peso",
                table: "corral",
                column: "id_rango_peso");

            migrationBuilder.CreateIndex(
                name: "IX_finca_id_ubicacion",
                table: "finca",
                column: "id_ubicacion");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "animal");

            migrationBuilder.DropTable(
                name: "corral");

            migrationBuilder.DropTable(
                name: "raza");

            migrationBuilder.DropTable(
                name: "finca");

            migrationBuilder.DropTable(
                name: "genero");

            migrationBuilder.DropTable(
                name: "rango_de_peso");

            migrationBuilder.DropTable(
                name: "direccion");
        }
    }
}
