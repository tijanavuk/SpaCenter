using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface GeneralDomainObject
    {
        string ReturnTableName();

        string ReturnKey();

        string ReturnCondition();

        string ValueForInsert();

        string ValueForUpdate();

        List<GeneralDomainObject> ReturnList(SqlDataReader reader);

        GeneralDomainObject ReadTableRow(DataRow row);

        string ReturnConditionMore();

        string ReturnCoditionID();

        string ReturnConditionForJoin();

        string ReturnTableNameForJoin();

        string ReturnCoditionForWhereInJoin();
    }
}
