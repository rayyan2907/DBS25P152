using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itec_Mangement
{
    public class load_data_class
    {
        public static DataTable getDataEvents(string id)
        {
            string query = $"select event_id,event_name,description,event_date,venue_name,c.committee_name as com_name,category_name from itec_events i join committees c on c.committee_id = i.committee_id join venues v on v.venue_id = i.venue_id join event_categories ec on ec.event_category_id= i.event_category_id join committees cm on cm.committee_id=i.committee_id where i.itec_id='{id}' order by event_id asc";
            return DatabaseHelper.Instance.GetData(query);
        }
        public static DataTable getParticipants(int year)
        {  //gets participants


            string query = $"select participant_id,name,email,contact,institute,role_name,i.year from participants p join roles r on r.role_id=p.role_id join itec_editions i on i.itec_id=p.itec_id where p.itec_id = {year} ";
            return DatabaseHelper.Instance.GetData(query);

        }
        public static DataTable getCommitteeData(int year)
        {  


            string query = $"select committee_name,member_id,name,role_name from committees  c left join committee_members cm on cm.committee_id=c.committee_id left join roles r on r.role_id=cm.role_id where c.committee_id = {year} ";
            return DatabaseHelper.Instance.GetData(query);

        }

        public static DataTable getCommittees(int year)
        {  //gets participants


            string query = $"select committee_id,i.year,committee_name from committees c join itec_editions i on i.itec_id=c.itec_id where i.itec_id = {year} ";
            return DatabaseHelper.Instance.GetData(query);

        }

        public static DataTable getDuties(int year)
        {


            string query = $"select duty_id,assigned_to,task_description,deadline,committee_name from duties d join committees c on c.committee_id = d.committee_id join lookup l on l.lookup_id=d.status_id where itec_id = {year} ";
            return DatabaseHelper.Instance.GetData(query);

        }

        public static DataTable getVenues()
        {


            string query = $"select venue_id,venue_name,capacity,location from venues ";
            return DatabaseHelper.Instance.GetData(query);

        }

    }
}
