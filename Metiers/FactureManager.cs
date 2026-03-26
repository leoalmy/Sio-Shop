using System;
using System.IO;
using System.Windows.Forms;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace Sio_Shop.Metiers
{
    public static class FactureManager
    {
        public static void GenererFacturePdf(long idVente, string nomClient, string infosProduit, string ttc)
        {
            try
            {
                // 1. Licence Community de QuestPDF
                QuestPDF.Settings.License = LicenseType.Community;

                // 2. --- LE CHEMIN DYNAMIQUE VERS TES DOCUMENTS ---
                // On récupère le chemin exact du dossier "Documents" de l'utilisateur actif
                string dossierDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string anneeActuelle = DateTime.Now.Year.ToString();

                // On combine les dossiers : Documents > Sio Shop > Factures_202X
                string dossier = Path.Combine(dossierDocuments, "Sio Shop", $"Factures_{anneeActuelle}");

                // On crée toute l'arborescence si elle n'existe pas encore
                if (!Directory.Exists(dossier))
                {
                    Directory.CreateDirectory(dossier);
                }

                // Le chemin final du fichier PDF
                string nomFichier = Path.Combine(dossier, $"Facture_{idVente:0000}_{nomClient.Replace(" ", "_")}.pdf");

                // 3. --- LE DESIGN PRO DU PDF ---
                Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Size(PageSizes.A4);
                        page.Margin(2, Unit.Centimetre);
                        page.PageColor(Colors.White);
                        page.DefaultTextStyle(x => x.FontSize(11).FontFamily(Fonts.Arial));

                        // --- EN-TÊTE ---
                        page.Header().Row(row =>
                        {
                            // Côté gauche : Infos de la boutique
                            row.RelativeItem().Column(col =>
                            {
                                col.Item().Text("SIO SHOP").FontSize(28).SemiBold().FontColor(Colors.Blue.Darken2);
                                col.Item().Text("123 Avenue des Développeurs");
                                col.Item().Text("80000 Amiens, FRANCE");
                                col.Item().Text("contact@sioshop.fr").FontColor(Colors.Blue.Medium);
                            });

                            // Côté droit : Infos de la facture
                            row.ConstantItem(170).Column(col =>
                            {
                                col.Item().Text("FACTURE").FontSize(24).SemiBold().FontColor(Colors.Grey.Darken2).AlignRight();
                                col.Item().Text($"N° Facture : {idVente:0000}").FontSize(12).AlignRight();
                                col.Item().Text($"Date : {DateTime.Now:dd/MM/yyyy}").FontSize(12).AlignRight();
                            });
                        });

                        // --- CONTENU CENTRAL ---
                        page.Content().PaddingVertical(1.5f, Unit.Centimetre).Column(col =>
                        {
                            // Bloc "Facturé à"
                            col.Item().PaddingBottom(1, Unit.Centimetre).Background(Colors.Grey.Lighten4).Padding(10).Column(c =>
                            {
                                c.Item().Text("Facturé à :").FontSize(10).FontColor(Colors.Grey.Darken1);
                                c.Item().Text(nomClient).FontSize(14).SemiBold();
                            });

                            // Le tableau de la commande
                            col.Item().Table(table =>
                            {
                                // Définition des largeurs de colonnes (3/4 pour le nom, 1/4 pour le prix)
                                table.ColumnsDefinition(columns =>
                                {
                                    columns.RelativeColumn(3);
                                    columns.RelativeColumn(1);
                                });

                                // L'en-tête du tableau
                                table.Header(header =>
                                {
                                    header.Cell().BorderBottom(2).BorderColor(Colors.Blue.Darken2).PaddingBottom(5).Text("Désignation du produit").SemiBold();
                                    header.Cell().BorderBottom(2).BorderColor(Colors.Blue.Darken2).PaddingBottom(5).Text("Montant TTC").SemiBold().AlignRight();
                                });

                                // La ligne du produit
                                table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten3).PaddingVertical(10).Text(infosProduit);
                                table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten3).PaddingVertical(10).Text(ttc).AlignRight();
                            });

                            // Le Total aligné à droite
                            col.Item().PaddingTop(20).AlignRight().Text(text =>
                            {
                                text.Span("Total à payer : ").FontSize(14);
                                text.Span(ttc).FontSize(16).SemiBold().FontColor(Colors.Red.Medium);
                            });
                        });

                        // --- PIED DE PAGE ---
                        page.Footer()
                            .AlignCenter()
                            .Text(text =>
                            {
                                text.Span("Merci de votre confiance ! ").SemiBold();
                                text.Span($"Document généré le {DateTime.Now:g}").FontColor(Colors.Grey.Medium);
                            });
                    });
                })
                .GeneratePdf(nomFichier);

                DialogResult reponse = MessageBox.Show(
                    $"Facture générée avec succès dans vos Documents !\n\nVoulez-vous l'ouvrir maintenant ?", 
                    "Facture prête", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question
                );

                // Si l'utilisateur clique sur "Oui"
                if (reponse == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(nomFichier) { UseShellExecute = true });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la création du PDF : " + ex.Message);
            }
        }
    }
}