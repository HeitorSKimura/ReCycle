using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReCycle.Infra.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class createDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence(
                name: "UserSequence");

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [UserSequence]"),
                    UserNomeCompleto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPFRG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserSenha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserTelefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserAtivo = table.Column<bool>(type: "bit", nullable: false),
                    UserRegistro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Coletores",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [UserSequence]"),
                    UserNomeCompleto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPFRG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserSenha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserTelefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserAtivo = table.Column<bool>(type: "bit", nullable: false),
                    UserRegistro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coletores", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Descartantes",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [UserSequence]"),
                    UserNomeCompleto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPFRG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserSenha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserTelefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserAtivo = table.Column<bool>(type: "bit", nullable: false),
                    UserRegistro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Descartantes", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Lojas",
                columns: table => new
                {
                    LojaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeFicticio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RazaoSocial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CNPJ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LojaAtivo = table.Column<bool>(type: "bit", nullable: false),
                    LojaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lojas", x => x.LojaId);
                });

            migrationBuilder.CreateTable(
                name: "Configs",
                columns: table => new
                {
                    ConfigId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataAlteracaoAdmin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configs", x => x.ConfigId);
                    table.ForeignKey(
                        name: "FK_Configs_Admins_UserId",
                        column: x => x.UserId,
                        principalTable: "Admins",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cupons",
                columns: table => new
                {
                    CupomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<int>(type: "int", nullable: false),
                    Validade = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LojaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cupons", x => x.CupomId);
                    table.ForeignKey(
                        name: "FK_Cupons_Lojas_LojaId",
                        column: x => x.LojaId,
                        principalTable: "Lojas",
                        principalColumn: "LojaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    EnderecoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Localidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroCasa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LojaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.EnderecoId);
                    table.ForeignKey(
                        name: "FK_Enderecos_Lojas_LojaId",
                        column: x => x.LojaId,
                        principalTable: "Lojas",
                        principalColumn: "LojaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AreasColeta",
                columns: table => new
                {
                    AreaColetaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Desocupado = table.Column<bool>(type: "bit", nullable: false),
                    ConfigId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreasColeta", x => x.AreaColetaId);
                    table.ForeignKey(
                        name: "FK_AreasColeta_Coletores_UserId",
                        column: x => x.UserId,
                        principalTable: "Coletores",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AreasColeta_Configs_ConfigId",
                        column: x => x.ConfigId,
                        principalTable: "Configs",
                        principalColumn: "ConfigId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserEnderecos",
                columns: table => new
                {
                    UserEnderecoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    EnderecoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEnderecos", x => x.UserEnderecoId);
                    table.ForeignKey(
                        name: "FK_UserEnderecos_Enderecos_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Enderecos",
                        principalColumn: "EnderecoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PontosColeta",
                columns: table => new
                {
                    PontoColetaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoordenadaX = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoordenadaY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Map = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataRegistroPontoColeta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AreaColetaId = table.Column<int>(type: "int", nullable: false),
                    EnderecoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PontosColeta", x => x.PontoColetaId);
                    table.ForeignKey(
                        name: "FK_PontosColeta_AreasColeta_AreaColetaId",
                        column: x => x.AreaColetaId,
                        principalTable: "AreasColeta",
                        principalColumn: "AreaColetaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PontosColeta_Enderecos_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Enderecos",
                        principalColumn: "EnderecoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pontuacoes",
                columns: table => new
                {
                    PontuacaoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Confirmacao = table.Column<bool>(type: "bit", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    PontuacaoAtivo = table.Column<bool>(type: "bit", nullable: false),
                    ConfigId = table.Column<int>(type: "int", nullable: false),
                    DescartanteId = table.Column<int>(type: "int", nullable: false),
                    PontoColetaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pontuacoes", x => x.PontuacaoId);
                    table.ForeignKey(
                        name: "FK_Pontuacoes_Configs_ConfigId",
                        column: x => x.ConfigId,
                        principalTable: "Configs",
                        principalColumn: "ConfigId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pontuacoes_Descartantes_DescartanteId",
                        column: x => x.DescartanteId,
                        principalTable: "Descartantes",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pontuacoes_PontosColeta_PontoColetaId",
                        column: x => x.PontoColetaId,
                        principalTable: "PontosColeta",
                        principalColumn: "PontoColetaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PontuacoesCupom",
                columns: table => new
                {
                    PontuacaoCupomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PontuacaoId = table.Column<int>(type: "int", nullable: false),
                    CupomId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PontuacoesCupom", x => x.PontuacaoCupomId);
                    table.ForeignKey(
                        name: "FK_PontuacoesCupom_Cupons_CupomId",
                        column: x => x.CupomId,
                        principalTable: "Cupons",
                        principalColumn: "CupomId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PontuacoesCupom_Pontuacoes_PontuacaoId",
                        column: x => x.PontuacaoId,
                        principalTable: "Pontuacoes",
                        principalColumn: "PontuacaoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AreasColeta_ConfigId",
                table: "AreasColeta",
                column: "ConfigId");

            migrationBuilder.CreateIndex(
                name: "IX_AreasColeta_UserId",
                table: "AreasColeta",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Configs_UserId",
                table: "Configs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Cupons_LojaId",
                table: "Cupons",
                column: "LojaId");

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_LojaId",
                table: "Enderecos",
                column: "LojaId");

            migrationBuilder.CreateIndex(
                name: "IX_PontosColeta_AreaColetaId",
                table: "PontosColeta",
                column: "AreaColetaId");

            migrationBuilder.CreateIndex(
                name: "IX_PontosColeta_EnderecoId",
                table: "PontosColeta",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pontuacoes_ConfigId",
                table: "Pontuacoes",
                column: "ConfigId");

            migrationBuilder.CreateIndex(
                name: "IX_Pontuacoes_DescartanteId",
                table: "Pontuacoes",
                column: "DescartanteId");

            migrationBuilder.CreateIndex(
                name: "IX_Pontuacoes_PontoColetaId",
                table: "Pontuacoes",
                column: "PontoColetaId");

            migrationBuilder.CreateIndex(
                name: "IX_PontuacoesCupom_CupomId",
                table: "PontuacoesCupom",
                column: "CupomId");

            migrationBuilder.CreateIndex(
                name: "IX_PontuacoesCupom_PontuacaoId",
                table: "PontuacoesCupom",
                column: "PontuacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEnderecos_EnderecoId",
                table: "UserEnderecos",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEnderecos_UserId",
                table: "UserEnderecos",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PontuacoesCupom");

            migrationBuilder.DropTable(
                name: "UserEnderecos");

            migrationBuilder.DropTable(
                name: "Cupons");

            migrationBuilder.DropTable(
                name: "Pontuacoes");

            migrationBuilder.DropTable(
                name: "Descartantes");

            migrationBuilder.DropTable(
                name: "PontosColeta");

            migrationBuilder.DropTable(
                name: "AreasColeta");

            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropTable(
                name: "Coletores");

            migrationBuilder.DropTable(
                name: "Configs");

            migrationBuilder.DropTable(
                name: "Lojas");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropSequence(
                name: "UserSequence");
        }
    }
}
