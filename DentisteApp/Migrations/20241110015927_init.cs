using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DentisteApp.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Factures_DossiersMedicaux_DossierMedicalID",
                table: "Factures");

            migrationBuilder.DropForeignKey(
                name: "FK_FeuillesDeSoin_DossiersMedicaux_DossierMedicalID",
                table: "FeuillesDeSoin");

            migrationBuilder.DropForeignKey(
                name: "FK_Imageries_DossiersMedicaux_DossierMedicalID",
                table: "Imageries");

            migrationBuilder.DropForeignKey(
                name: "FK_Ordonnances_DossiersMedicaux_DossierMedicalID",
                table: "Ordonnances");

            migrationBuilder.DropForeignKey(
                name: "FK_Paiements_DossiersMedicaux_DossierMedicalID",
                table: "Paiements");

            migrationBuilder.DropIndex(
                name: "IX_DossiersMedicaux_PatientID",
                table: "DossiersMedicaux");

            migrationBuilder.AlterColumn<int>(
                name: "DossierMedicalID",
                table: "Paiements",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "DossierMedicalID",
                table: "Ordonnances",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "DossierMedicalID",
                table: "Imageries",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "DossierMedicalID",
                table: "FeuillesDeSoin",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "DossierMedicalID",
                table: "Factures",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.CreateIndex(
                name: "IX_DossiersMedicaux_PatientID",
                table: "DossiersMedicaux",
                column: "PatientID");

            migrationBuilder.AddForeignKey(
                name: "FK_Factures_DossiersMedicaux_DossierMedicalID",
                table: "Factures",
                column: "DossierMedicalID",
                principalTable: "DossiersMedicaux",
                principalColumn: "DossierMedicalID");

            migrationBuilder.AddForeignKey(
                name: "FK_FeuillesDeSoin_DossiersMedicaux_DossierMedicalID",
                table: "FeuillesDeSoin",
                column: "DossierMedicalID",
                principalTable: "DossiersMedicaux",
                principalColumn: "DossierMedicalID");

            migrationBuilder.AddForeignKey(
                name: "FK_Imageries_DossiersMedicaux_DossierMedicalID",
                table: "Imageries",
                column: "DossierMedicalID",
                principalTable: "DossiersMedicaux",
                principalColumn: "DossierMedicalID");

            migrationBuilder.AddForeignKey(
                name: "FK_Ordonnances_DossiersMedicaux_DossierMedicalID",
                table: "Ordonnances",
                column: "DossierMedicalID",
                principalTable: "DossiersMedicaux",
                principalColumn: "DossierMedicalID");

            migrationBuilder.AddForeignKey(
                name: "FK_Paiements_DossiersMedicaux_DossierMedicalID",
                table: "Paiements",
                column: "DossierMedicalID",
                principalTable: "DossiersMedicaux",
                principalColumn: "DossierMedicalID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Factures_DossiersMedicaux_DossierMedicalID",
                table: "Factures");

            migrationBuilder.DropForeignKey(
                name: "FK_FeuillesDeSoin_DossiersMedicaux_DossierMedicalID",
                table: "FeuillesDeSoin");

            migrationBuilder.DropForeignKey(
                name: "FK_Imageries_DossiersMedicaux_DossierMedicalID",
                table: "Imageries");

            migrationBuilder.DropForeignKey(
                name: "FK_Ordonnances_DossiersMedicaux_DossierMedicalID",
                table: "Ordonnances");

            migrationBuilder.DropForeignKey(
                name: "FK_Paiements_DossiersMedicaux_DossierMedicalID",
                table: "Paiements");

            migrationBuilder.DropIndex(
                name: "IX_DossiersMedicaux_PatientID",
                table: "DossiersMedicaux");

            migrationBuilder.AlterColumn<int>(
                name: "DossierMedicalID",
                table: "Paiements",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DossierMedicalID",
                table: "Ordonnances",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DossierMedicalID",
                table: "Imageries",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DossierMedicalID",
                table: "FeuillesDeSoin",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DossierMedicalID",
                table: "Factures",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DossiersMedicaux_PatientID",
                table: "DossiersMedicaux",
                column: "PatientID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Factures_DossiersMedicaux_DossierMedicalID",
                table: "Factures",
                column: "DossierMedicalID",
                principalTable: "DossiersMedicaux",
                principalColumn: "DossierMedicalID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FeuillesDeSoin_DossiersMedicaux_DossierMedicalID",
                table: "FeuillesDeSoin",
                column: "DossierMedicalID",
                principalTable: "DossiersMedicaux",
                principalColumn: "DossierMedicalID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Imageries_DossiersMedicaux_DossierMedicalID",
                table: "Imageries",
                column: "DossierMedicalID",
                principalTable: "DossiersMedicaux",
                principalColumn: "DossierMedicalID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ordonnances_DossiersMedicaux_DossierMedicalID",
                table: "Ordonnances",
                column: "DossierMedicalID",
                principalTable: "DossiersMedicaux",
                principalColumn: "DossierMedicalID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Paiements_DossiersMedicaux_DossierMedicalID",
                table: "Paiements",
                column: "DossierMedicalID",
                principalTable: "DossiersMedicaux",
                principalColumn: "DossierMedicalID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
