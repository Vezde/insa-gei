
// This file has been generated by the GUI designer. Do not modify.

public partial class FenetrePrincipale
{
	private global::Gtk.UIManager UIManager;
	
	private global::Gtk.Action VoitureAction;
	
	private global::Gtk.Action EntretienAction;
	
	private global::Gtk.Action CarnetsDEntretienAction;
	
	private global::Gtk.Action SystemeAction;
	
	private global::Gtk.Action ImprimerAction;
	
	private global::Gtk.Action AideAction;
	
	private global::Gtk.Action NouveauCarnetAction;
	
	private global::Gtk.Action OuvrirUnCarnetAction;
	
	private global::Gtk.Action ChangerLaBaseDAttributsAction;
	
	private global::Gtk.Action ConfigurerAction;
	
	private global::Gtk.Action AjouterUnAttributAction;
	
	private global::Gtk.Action SupprimerUnAttributAction;
	
	private global::Gtk.Action ImprimerLaFicheSelectionneAction;
	
	private global::Gtk.Action ImprimerLEnsembleDuCarnetAction;
	
	private global::Gtk.Action ConfigurerLImrimanteAction;
	
	private global::Gtk.Action SupprimerUnEntretienPeriodiqueAction;
	
	private global::Gtk.Action AttributAction;
	
	private global::Gtk.Action EnregistrerLeCarnetAction;
	
	private global::Gtk.Action EnregistrerSousAction;
	
	private global::Gtk.Action QuitterAction;
	
	private global::Gtk.Action IndexAction;
	
	private global::Gtk.Action AProposDeAction;
	
	private global::Gtk.VBox vbox1;
	
	private global::Gtk.MenuBar menuPrincipal;
	
	private global::Gtk.HBox hbox1;
	
	private global::Gtk.Toolbar BarreOutils;
	
	private global::Gtk.VBox vbox2;
	
	private global::Gtk.ScrolledWindow scrolledwindow2;
	
	private global::Gtk.TreeView EntretienTreeview;
	
	private global::Gtk.Statusbar statusbar1;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget FenetrePrincipale
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.VoitureAction = new global::Gtk.Action ("VoitureAction", null, global::Mono.Unix.Catalog.GetString ("Information sur le vehicule"), "Voiture");
		w1.Add (this.VoitureAction, null);
		this.EntretienAction = new global::Gtk.Action ("EntretienAction", null, global::Mono.Unix.Catalog.GetString ("Ajouter une fiche d'entretien"), "Entretien");
		w1.Add (this.EntretienAction, null);
		this.CarnetsDEntretienAction = new global::Gtk.Action ("CarnetsDEntretienAction", global::Mono.Unix.Catalog.GetString ("Carnets d'entretien"), null, null);
		this.CarnetsDEntretienAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Fichier");
		w1.Add (this.CarnetsDEntretienAction, null);
		this.SystemeAction = new global::Gtk.Action ("SystemeAction", global::Mono.Unix.Catalog.GetString ("Systeme"), null, null);
		this.SystemeAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Vehicules");
		w1.Add (this.SystemeAction, null);
		this.ImprimerAction = new global::Gtk.Action ("ImprimerAction", global::Mono.Unix.Catalog.GetString ("Imprimer"), null, null);
		this.ImprimerAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Entretiens");
		w1.Add (this.ImprimerAction, null);
		this.AideAction = new global::Gtk.Action ("AideAction", global::Mono.Unix.Catalog.GetString ("Aide"), null, null);
		this.AideAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Aide");
		w1.Add (this.AideAction, null);
		this.NouveauCarnetAction = new global::Gtk.Action ("NouveauCarnetAction", global::Mono.Unix.Catalog.GetString ("Nouveau carnet ..."), null, null);
		this.NouveauCarnetAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Ouvrir");
		w1.Add (this.NouveauCarnetAction, null);
		this.OuvrirUnCarnetAction = new global::Gtk.Action ("OuvrirUnCarnetAction", global::Mono.Unix.Catalog.GetString ("Ouvrir un carnet ..."), null, null);
		this.OuvrirUnCarnetAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Quitter");
		w1.Add (this.OuvrirUnCarnetAction, null);
		this.ChangerLaBaseDAttributsAction = new global::Gtk.Action ("ChangerLaBaseDAttributsAction", global::Mono.Unix.Catalog.GetString ("Changer la base d'attributs ..."), null, null);
		this.ChangerLaBaseDAttributsAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Ajouter un vehicule");
		w1.Add (this.ChangerLaBaseDAttributsAction, null);
		this.ConfigurerAction = new global::Gtk.Action ("ConfigurerAction", global::Mono.Unix.Catalog.GetString ("Configurer ..."), null, null);
		this.ConfigurerAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Supprimer un vehicule");
		w1.Add (this.ConfigurerAction, null);
		this.AjouterUnAttributAction = new global::Gtk.Action ("AjouterUnAttributAction", global::Mono.Unix.Catalog.GetString ("Ajouter un attribut"), null, null);
		this.AjouterUnAttributAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Ajouter un attribut");
		w1.Add (this.AjouterUnAttributAction, null);
		this.SupprimerUnAttributAction = new global::Gtk.Action ("SupprimerUnAttributAction", global::Mono.Unix.Catalog.GetString ("Supprimer un attribut"), null, null);
		this.SupprimerUnAttributAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Supprimer un attribut");
		w1.Add (this.SupprimerUnAttributAction, null);
		this.ImprimerLaFicheSelectionneAction = new global::Gtk.Action ("ImprimerLaFicheSelectionneAction", global::Mono.Unix.Catalog.GetString ("Imprimer la fiche selectionnée"), null, null);
		this.ImprimerLaFicheSelectionneAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Ajouter une fiche");
		w1.Add (this.ImprimerLaFicheSelectionneAction, null);
		this.ImprimerLEnsembleDuCarnetAction = new global::Gtk.Action ("ImprimerLEnsembleDuCarnetAction", global::Mono.Unix.Catalog.GetString ("Imprimer l'ensemble du carnet"), null, null);
		this.ImprimerLEnsembleDuCarnetAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Supprimer une fiche");
		w1.Add (this.ImprimerLEnsembleDuCarnetAction, null);
		this.ConfigurerLImrimanteAction = new global::Gtk.Action ("ConfigurerLImrimanteAction", global::Mono.Unix.Catalog.GetString ("Configurer l'imrimante ..."), null, null);
		this.ConfigurerLImrimanteAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Ajouter un entretien periodique");
		w1.Add (this.ConfigurerLImrimanteAction, null);
		this.SupprimerUnEntretienPeriodiqueAction = new global::Gtk.Action ("SupprimerUnEntretienPeriodiqueAction", global::Mono.Unix.Catalog.GetString ("Supprimer un entretien periodique"), null, null);
		this.SupprimerUnEntretienPeriodiqueAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Supprimer un entretien periodique");
		w1.Add (this.SupprimerUnEntretienPeriodiqueAction, null);
		this.AttributAction = new global::Gtk.Action ("AttributAction", null, global::Mono.Unix.Catalog.GetString ("Gerer les attributs ..."), "Attribut");
		w1.Add (this.AttributAction, null);
		this.EnregistrerLeCarnetAction = new global::Gtk.Action ("EnregistrerLeCarnetAction", global::Mono.Unix.Catalog.GetString ("Enregistrer le carnet"), null, null);
		this.EnregistrerLeCarnetAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Enregistrer le carnet");
		w1.Add (this.EnregistrerLeCarnetAction, null);
		this.EnregistrerSousAction = new global::Gtk.Action ("EnregistrerSousAction", global::Mono.Unix.Catalog.GetString ("Enregistrer sous ..."), null, null);
		this.EnregistrerSousAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Enregistrer sous ...");
		w1.Add (this.EnregistrerSousAction, null);
		this.QuitterAction = new global::Gtk.Action ("QuitterAction", global::Mono.Unix.Catalog.GetString ("Quitter"), null, null);
		this.QuitterAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Quitter");
		w1.Add (this.QuitterAction, null);
		this.IndexAction = new global::Gtk.Action ("IndexAction", global::Mono.Unix.Catalog.GetString ("Index"), null, null);
		this.IndexAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Index");
		w1.Add (this.IndexAction, null);
		this.AProposDeAction = new global::Gtk.Action ("AProposDeAction", global::Mono.Unix.Catalog.GetString ("A propos de ..."), null, null);
		this.AProposDeAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("A propos de ...");
		w1.Add (this.AProposDeAction, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "FenetrePrincipale";
		this.Title = global::Mono.Unix.Catalog.GetString ("EntretienAuto");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child FenetrePrincipale.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><menubar name='menuPrincipal'><menu name='CarnetsDEntretienAction' action='CarnetsDEntretienAction'><menuitem name='NouveauCarnetAction' action='NouveauCarnetAction'/><menuitem name='OuvrirUnCarnetAction' action='OuvrirUnCarnetAction'/><menuitem name='EnregistrerLeCarnetAction' action='EnregistrerLeCarnetAction'/><menuitem name='EnregistrerSousAction' action='EnregistrerSousAction'/><menuitem name='QuitterAction' action='QuitterAction'/></menu><menu name='SystemeAction' action='SystemeAction'><menuitem name='ChangerLaBaseDAttributsAction' action='ChangerLaBaseDAttributsAction'/><menuitem name='ConfigurerAction' action='ConfigurerAction'/></menu><menu name='ImprimerAction' action='ImprimerAction'><menuitem name='ImprimerLaFicheSelectionneAction' action='ImprimerLaFicheSelectionneAction'/><menuitem name='ImprimerLEnsembleDuCarnetAction' action='ImprimerLEnsembleDuCarnetAction'/><menuitem name='ConfigurerLImrimanteAction' action='ConfigurerLImrimanteAction'/></menu><menu name='AideAction' action='AideAction'><menuitem name='IndexAction' action='IndexAction'/><menuitem name='AProposDeAction' action='AProposDeAction'/></menu></menubar></ui>");
		this.menuPrincipal = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menuPrincipal")));
		this.menuPrincipal.Name = "menuPrincipal";
		this.vbox1.Add (this.menuPrincipal);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.menuPrincipal]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><toolbar name='BarreOutils'><toolitem name='VoitureAction' action='VoitureAction'/><toolitem name='EntretienAction' action='EntretienAction'/><toolitem name='AttributAction' action='AttributAction'/></toolbar></ui>");
		this.BarreOutils = ((global::Gtk.Toolbar)(this.UIManager.GetWidget ("/BarreOutils")));
		this.BarreOutils.Name = "BarreOutils";
		this.BarreOutils.Orientation = ((global::Gtk.Orientation)(1));
		this.BarreOutils.ShowArrow = false;
		this.hbox1.Add (this.BarreOutils);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.BarreOutils]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.scrolledwindow2 = new global::Gtk.ScrolledWindow ();
		this.scrolledwindow2.CanFocus = true;
		this.scrolledwindow2.Name = "scrolledwindow2";
		this.scrolledwindow2.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child scrolledwindow2.Gtk.Container+ContainerChild
		this.EntretienTreeview = new global::Gtk.TreeView ();
		this.EntretienTreeview.CanFocus = true;
		this.EntretienTreeview.Name = "EntretienTreeview";
		this.scrolledwindow2.Add (this.EntretienTreeview);
		this.vbox2.Add (this.scrolledwindow2);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.scrolledwindow2]));
		w5.Position = 0;
		this.hbox1.Add (this.vbox2);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox2]));
		w6.Position = 1;
		this.vbox1.Add (this.hbox1);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
		w7.Position = 1;
		// Container child vbox1.Gtk.Box+BoxChild
		this.statusbar1 = new global::Gtk.Statusbar ();
		this.statusbar1.Name = "statusbar1";
		this.statusbar1.Spacing = 6;
		this.vbox1.Add (this.statusbar1);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.statusbar1]));
		w8.Position = 2;
		w8.Expand = false;
		w8.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 892;
		this.DefaultHeight = 556;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.IndexAction.Activated += new global::System.EventHandler (this.OnIndexActionActivated);
		this.AProposDeAction.Activated += new global::System.EventHandler (this.OnAProposDeActionActivated);
	}
}
