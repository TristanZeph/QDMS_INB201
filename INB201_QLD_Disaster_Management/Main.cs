using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

using INB201_QLD_Disaster_Management.Helper_Classes;
using INB201_QLD_Disaster_Management.Forms;

namespace INB201_QLD_Disaster_Management
{
    /// <summary>
    /// This form is the parent form which handles the interaction of
    /// child forms and displays child forms.
    /// 
    /// Author: Tristan Le
    /// ID:     N8320055
    /// </summary>
    public partial class Main : Form
    {
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

        private List<Form> forms;

        // whether a user has login session
        private bool isAdmin = false;

        // the personnel id of the user. For user access control.
        // the user should only respond to their assigned incident.
        private int userId;         
        #endregion

        #region Properties

        /// <summary>
        /// accessor for incident edit form, to be able to pass incident id
        /// </summary>
        public IncidentEditForm IncidentEditForm
        {
            get { return incidentEditForm; }
        }

        /// <summary>
        /// accessor for personnel edit form, to be able to pass personnel id
        /// </summary>
        public PersonnelEditForm PersonnelEditForm
        {
            get { return personnelEditForm; }
        }

        /// <summary>
        /// Get/set accessor for isAdmin
        /// </summary>
        public bool IsAdmin
        {
            get { return isAdmin; }
            set { isAdmin = value; }
        }

        /// <summary>
        /// Get/set accessor for userId
        /// </summary>
        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        #endregion

        #region Initialise

        /// <summary>
        /// Run main program
        /// </summary>
        public Main()
        {
            InitializeComponent();
            Initialise();
        }

        /// <summary>
        /// Intialises all forms in the program
        /// </summary>
        private void Initialise()
        {
            forms = new List<Form>();

            //homeForm
            homeForm = new HomeForm(this);
            forms.Add(homeForm);

            //incident Query form
            incidentQueryForm = new IncidentQueryForm(this);
            forms.Add(incidentQueryForm);

            //incident edit form
            incidentEditForm = new IncidentEditForm(this);
            forms.Add(incidentEditForm);

            // personnel query form
            personnelQueryForm = new PersonnelQueryForm(this);
            forms.Add(personnelQueryForm);

            // personnel edit form
            personnelEditForm = new PersonnelEditForm(this);
            forms.Add(personnelEditForm);

            //incident map form
            incidentMap = new IncidentMap(this);
            forms.Add(incidentMap);

            //reports form
            reportsForm = new ReportsForm(this);
            forms.Add(reportsForm);

            // assign mdiParent to this form
            foreach (Form form in forms)
                form.MdiParent = this;

            OpenForm(HOME);
        }

        #endregion

        #region ToolStrip Methods

        /// <summary>
        /// Opens the home page
        /// </summary>
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(HOME);
        }

        /// <summary>
        /// closes the application
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Opens the incident query page
        /// </summary>
        private void incidentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(INCIDENT_QUERY);
        }

        /// <summary>
        /// opens the personnel query form
        /// </summary>
        private void personnelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(PERSONNEL_QUERY);
        }

        /// <summary>
        /// Opens the incident map form
        /// </summary>
        private void incidentMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(INCIDENT_MAP);
        }

        /// <summary>
        /// Opens the report page
        /// </summary>
        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(REPORTS);
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Open the form based on the index
        /// </summary>
        public void OpenForm(int i)
        {
            forms[i].Show();
            forms[i].Activate();
        }

        /// <summary>
        /// Activates admin functions to 
        /// personnel, incident and reports pages
        /// </summary>
        public void EnableAdminFunctions()
        {
            adminToolStripMenuItem.Enabled = true;
        }

        /// <summary>
        /// deactivates admin functions to 
        /// personnel, incident and reports pages
        /// </summary>
        public void DisableAdminFunctions()
        {
            adminToolStripMenuItem.Enabled = false;
        }

        #endregion
    }
}
