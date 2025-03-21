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
        public static DataTable participantRep(int id)
        {
            string query = $"select registration_id,name,fee_amount,l.value as pay_status,event_name,email,contact,institute,l1.value as role,event_date from event_participants e join participants p on p.participant_id=e.participant_id join lookup l on l.lookup_id=e.payment_status_id join itec_events ev on ev.event_id=e.event_id join itec_editions i on i.itec_id=ev.itec_id join lookup l1 on l1.lookup_id=p.role_id where ev.itec_id = {id} order by registration_id asc";
            return DatabaseHelper.Instance.GetData(query);
        }

        public static DataTable CommRep(int id)
        {
            string query = $"select duty_id,committee_name,assigned_to,task_description,deadline,value from duties d join committees c on c.committee_id = d.committee_id join lookup l on l.lookup_id = d.status_id  join itec_editions i on i.itec_id=c.itec_id where i.itec_id = {id}";
            return DatabaseHelper.Instance.GetData(query);
        }

        public static DataTable Leaderboard(int id)
        {
            string query = $"select result_id,e.event_name,p.name,t.team_name,position,score,remarks,event_date from event_results r join itec_events e on e.event_id=r.event_id join itec_editions i on i.itec_id = e.itec_id join participants p on p.participant_id = r.participant_id join teams t on r.team_id =t.team_id where position <=10  and i.itec_id = {id} order by r.event_id,position asc";
            return DatabaseHelper.Instance.GetData(query);
        }

        public static DataTable FinanceRep(int id)
        {
            string query = $"select sum(amount) as total_income ,event_name,e.description,event_date from finances f join lookup l on l.lookup_id = f.type_id join itec_events e on e.event_id=f.event_id where value = 'Ticket Sales' or value = 'Sponsorship'  and e.itec_id = {id} group by f.event_id";
            return DatabaseHelper.Instance.GetData(query);
        }

        public static DataTable FinanceExpenseRep(int id)
        {
            string query = $"select sum(amount) as total_income ,event_name,e.description,event_date from finances f join lookup l on l.lookup_id = f.type_id join itec_events e on e.event_id=f.event_id where value = 'Expense'  and e.itec_id = {id} group by f.event_id";
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

        public static DataTable getVenuesAllocations(int id,int itec)
        {


            string query = $"select venue_allocation_id,assigned_date,assigned_time,venue_name,event_name from venue_allocations va join venues v on v.venue_id=va.venue_id join itec_events e on e.event_id=va.event_id join itec_editions i on i.itec_id=e.itec_id where v.venue_id={id} and i.itec_id={itec}";
            return DatabaseHelper.Instance.GetData(query);

        }


        public static DataTable getSponsors()
        {


            string query = $"select sponsor_id , sponsor_name, contact from sponsors ";
            return DatabaseHelper.Instance.GetData(query);

        }



        public static DataTable getVendors()
        {


            string query = $"select vendor_id,vendor_name,contact,service_type from vendors ";
            return DatabaseHelper.Instance.GetData(query);

        }

        public static DataTable getTransactions(int id)
        {


            string query = $"select transaction_id,i.year,event_name,l.value,amount,from_entity_type,to_entity_type,f.description,date_recorded from finances f join itec_editions i on i.itec_id=f.itec_id join itec_events e on e.event_id=f.event_id join lookup l on l.lookup_id=f.type_id where i.itec_id= {id}";
            return DatabaseHelper.Instance.GetData(query);

        }


        public static DataTable getEventResults(int id)
        {


            string query = $"select result_id,event_name,team_name,p.name,position,score,remarks from event_results r join itec_events e on e.event_id=r.event_id join teams t on t.team_id=r.team_id join participants p on p.participant_id = r.participant_id join itec_editions i on e.itec_id=i.itec_id where i.itec_id={id}";
            return DatabaseHelper.Instance.GetData(query);

        }

    }
}
