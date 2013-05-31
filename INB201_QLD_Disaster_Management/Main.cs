using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

using INB201_QLD_Disaster_Management.Helper_Classes;
using INB201_QLD_Disaster_Management.Forms;

namespace INB201_QLD_Disaster_Management {
    /// <summary>
    /// This is the main form of the program. It acts as the parent form
    /// with an MDI container and handles the transitions of child forms.
    /// 
    /// Author: Tristan Le
    /// ID:     N8320055
    /// </summary>
    public partial class Main : Form {

        #region Fields

        // list of incident types
        private const string FIRE = "Fire";
        private const string STORM = "Thunder Storm";
        private const string FLOOD = "Flood";
        private const string OTHER = "Other";

        public readonly string[] IncidentTypes = { FIRE, STORM, FLOOD, OTHER };

        // list of incident statuses
        private const string POSSIBLE = "Possible";
        private const string ACTIVE = "Active";
        private const string ENDED = "Ended";

        public readonly string[] IncidentStatuses = { POSSIBLE, ACTIVE, ENDED };

        // types of personnel
        private const string POLICE = "Police";
        private const string MEDIC = "Paramedic";
        private const string FIRE_FIGHTER = "Fire Brigade";
        private const string VOLUNTEER = "Volunteer";

        public readonly string[] PersonnelTypes = { POLICE, MEDIC, FIRE_FIGHTER, VOLUNTEER };

        // status of personnel
        private const string UNASSIGNED = "Unassigned";
        private const string IDLE = "Idle";
        private const string STANDBY = "Standby";
        private const string DEPLOYED = "Deployed";
        private const string REST = "Resting";
        private const string MISSING = "Missing";
        private const string DECEASED = "Deceased";

        public readonly string[]
            PersonnelStatuses = { UNASSIGNED, IDLE, STANDBY, DEPLOYED, REST, MISSING, DECEASED };

        // index of form pages
        public readonly int HOME = 0;
        public readonly int INCIDENT_QUERY = 1;
        public readonly int INCIDENT_EDIT = 2;
        public readonly int PERSONNEL_QUERY = 3;
        public readonly int PERSONNEL_EDIT = 4;
        public readonly int INCIDENT_MAP = 5;
        public readonly int REPORTS = 6;
        public readonly int LOGIN = 7;

        // SQL query class 
        public readonly SQL SQL = new SQL();

        //forms in the program
        private HomeForm homeForm;
        private IncidentQueryForm incidentQueryForm;
        private IncidentEditForm incidentEditForm;
        private PersonnelQueryForm personnelQueryForm;
        private PersonnelEditForm personnelEditForm;
        private IncidentMap incidentMap;
        private ReportsForm reportsForm;
        private LogInForm logInForm;

        private List<Form> forms;

        // whether a user has login session
        private bool isAdmin = false;

        // used to display account name in home screen
        private const string PUBLIC = "Public";
        private string accountName = PUBLIC;

        #endregion

        #region Properties

        /// <summary>
        /// accessor for incident edit form, to be able to pass incident id
        /// </summary>
        public IncidentEditForm IncidentEditForm {
            get { return incidentEditForm; }
        }

        /// <summary>
        /// accessor for personnel edit form, to be able to pass personnel id
        /// </summary>
        public PersonnelEditForm PersonnelEditForm {
            get { return personnelEditForm; }
        }

        /// <summary>
        /// Get/set accessor for isAdmin
        /// </summary>
        public bool IsAdmin {
            get { return isAdmin; }
            set { isAdmin = value; }
        }

        /// <summary>
        /// get/set accesor for accountName
        /// </summary>
        public string AccountName {
            get { return accountName; }
            set { accountName = value; }
        }

        #endregion

        #region Initialise

        /// <summary>
        /// Constructs and runs the main program
        /// </summary>
        public Main() {
            InitializeComponent();
            Initialise();
        }

        /// <summary>
        /// Intialises all forms in the program and adds them to the form List. 
        /// Open the HOME form as the default screen.
        /// </summary>
        private void Initialise() {
            forms = new List<Form>();

            homeForm = new HomeForm(this);
            forms.Add(homeForm);

            incidentQueryForm = new IncidentQueryForm(this);
            forms.Add(incidentQueryForm);

            incidentEditForm = new IncidentEditForm(this);
            forms.Add(incidentEditForm);

            personnelQueryForm = new PersonnelQueryForm(this);
            forms.Add(personnelQueryForm);

            personnelEditForm = new PersonnelEditForm(this);
            forms.Add(personnelEditForm);

            incidentMap = new IncidentMap(this);
            forms.Add(incidentMap);

            reportsForm = new ReportsForm(this);
            forms.Add(reportsForm);

            logInForm = new LogInForm(this);
            forms.Add(logInForm);

            // assign mdiParent to this form
            foreach (Form form in forms)
                form.MdiParent = this;

            OpenForm(HOME);
        }

        #endregion

        #region ToolStrip Methods

        /// <summary>
        /// ToolStrip methods opens the form which is assigned to it.
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void homeToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenForm(HOME);
        }
        private void incidentToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenForm(INCIDENT_QUERY);
        }
        private void personnelToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenForm(PERSONNEL_QUERY);
        }
        private void incidentMapToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenForm(INCIDENT_MAP);
        }
        private void reportsToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenForm(REPORTS);
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Open the form based on the index i.
        /// </summary>
        public void OpenForm(int i) {
            try {
                forms[i].Show();
                forms[i].Activate();
            } catch (Exception e) {
                // catch out of range exception
                MessageBox.Show(e.Message + " Please contact adminstrator."); 
            }
        }

        /// <summary>
        /// Enables the 'admin' tab of the toolStrip.
        /// </summary>
        public void EnableAdminFunctions() {
            adminToolStripMenuItem.Enabled = true;
        }

        /// <summary>
        /// Disables the 'admin' tab of the toolStrip.
        /// </summary>
        public void DisableAdminFunctions() {
            adminToolStripMenuItem.Enabled = false;
        }

        #endregion
    }
}
