using GymManager.ApplicationServices.Members;
using GymManager.Core.Members;
using GymManager.DataAccess;
using GymManager.DataAccess.Reports;
using GymManager.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Reporting.NETCore;
using MySqlConnector;
using System.Data;
using System.Data.SqlClient;
using Wkhtmltopdf.NetCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace GymManager.Web.Controllers
{
    public class ReportsController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        private readonly IGeneratePdf _generatePdf;
        private readonly IStaffAttendanceAppService _staffAttendanceAppService;
        private readonly GymManagerContext _context;
        public ReportsController(IWebHostEnvironment environment, IGeneratePdf generatePdf, IConfiguration configuration, IStaffAttendanceAppService staffAttendanceAppService, GymManagerContext context) 
        {
            _environment = environment;
            _generatePdf = generatePdf;
            _staffAttendanceAppService = staffAttendanceAppService;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> StaffAttendance()
        {
            var attendances = await _staffAttendanceAppService.GetAttendancesAsync();

            var lastWeekMembers = await _staffAttendanceAppService.GetLastWeekAsync();

            string path = System.IO.Path.Combine(_environment.ContentRootPath, "Reports\\StaffAttendance.rdlc");
            Stream reportDefinition = System.IO.File.OpenRead(path);

            LocalReport report = new LocalReport();
            report.EnableExternalImages = true;
            report.LoadReportDefinition(reportDefinition);

            StaffAttendanceDataSet dataSet = new StaffAttendanceDataSet();

            foreach (var StaffAttendance in attendances)
            {
                StaffAttendanceDataSet.StaffAttendanceRow row = dataSet.StaffAttendance.NewStaffAttendanceRow();

                row.Name = StaffAttendance.Item1.Name;
                row.LastName = StaffAttendance.Item1.LastName;
                row.Count = StaffAttendance.Item2;

                dataSet.StaffAttendance.Rows.Add(row);
            }

            foreach (var StaffAttendanceLastWeek in lastWeekMembers)
            {
                StaffAttendanceDataSet.StaffAttendanceLastWeekRow row = dataSet.StaffAttendanceLastWeek.NewStaffAttendanceLastWeekRow();

                string dayOfWeek = StaffAttendanceLastWeek.DateTime.DayOfWeek.ToString();

                row.DateTime = dayOfWeek;

                dataSet.StaffAttendanceLastWeek.Rows.Add(row);
            }

            byte[] streamBytes = null;
            string mimeType = "";
            string encoding = "";
            string filenameExtension = "";
            string reportName = "StaffAttendace";
            string[] streamids = null;
            Warning[] warnings = null;

            report.SetParameters(new ReportParameter[] {
                new ReportParameter("DateFrom", DateTime.Today.AddDays(-30).ToString() ),
                new ReportParameter("DateTo", DateTime.Today.ToString() )
            });

            report.DataSources.Add(new ReportDataSource("StaffAttendance", (System.Data.DataTable)dataSet.StaffAttendance));
            report.DataSources.Add(new ReportDataSource("StaffAttendanceLastWeek", (System.Data.DataTable)dataSet.StaffAttendanceLastWeek));

            streamBytes = report.Render("PDF", null, out mimeType, out encoding, out filenameExtension, out streamids, out warnings);

            return File(streamBytes, mimeType, $"{reportName}.{filenameExtension}");




            //// Fecha inicial y final del período para calcular la asistencia
            //DateTime startDate = DateTime.Today.AddDays(-30);
            //DateTime endDate = DateTime.Today;

            //var staffAttendanceData = await _context.Staffattendances
            //.Where(a => a.Fecha >= startDate && a.Fecha <= endDate) // Filtrar por el período deseado
            //.GroupBy(a => new { a.Name, a.LastName }) // Agrupar por nombre y apellido
            //.Select(g => new
            //{
            //    Name = g.Key.Name,
            //    LastName = g.Key.LastName,
            //    AttendanceCount = g.Count(), // Contar el número total de registros en el grupo
            //    Fecha = g.Max(a => a.Fecha) // Obtener la fecha más reciente de asistencia
            //})
            //.OrderByDescending(g => g.AttendanceCount) // Ordenar por la cantidad de asistencias (de mayor a menor)
            //.ToListAsync();

            //// Convertir los datos en un DataTable
            //DataTable dataTable = new DataTable();
            //dataTable.Columns.Add("Name", typeof(string));
            //dataTable.Columns.Add("LastName", typeof(string));
            //dataTable.Columns.Add("Count", typeof(int)); // Agregar la columna de conteo de asistencias
            //dataTable.Columns.Add("Fecha", typeof(DateTime)); // Agregar la columna de fecha

            //foreach (var attendance in staffAttendanceData)
            //{
            //    DataRow row = dataTable.NewRow();
            //    row["Name"] = attendance.Name;
            //    row["LastName"] = attendance.LastName;
            //    row["Count"] = attendance.AttendanceCount;
            //    row["Fecha"] = attendance.Fecha;
            //    dataTable.Rows.Add(row);
            //}

            //// Ruta del archivo de informe
            //string path = System.IO.Path.Combine(_environment.ContentRootPath, "Reports\\StaffAttendance.rdlc");
            //Stream reportDefinition = System.IO.File.OpenRead(path);

            //LocalReport report = new LocalReport();
            //report.EnableExternalImages = true;
            //report.LoadReportDefinition(reportDefinition);

            //// Crear un DataSet para el informe y agregar el DataTable
            //StaffAttendanceDataSet dataSet = new StaffAttendanceDataSet();
            //dataSet.Tables["StaffAttendance"].Merge(dataTable);

            //// Generar el informe en formato PDF
            //byte[] streamBytes = null;
            //string mimetype = "";
            //string encoding = "";
            //string filenameExtension = "";
            //string reportName = "StaffAttendance";
            //string[] streamids = null;
            //Warning[] warnings = null;

            //report.SetParameters(new ReportParameter[] {
            //    new ReportParameter("DateFrom", DateTime.Today.AddDays(-30).ToString()),
            //    new ReportParameter("DateTo", DateTime.Today.ToString())
            //});

            //report.DataSources.Add(new ReportDataSource("StaffAttendance", (System.Data.DataTable)dataSet.Tables["StaffAttendance"]));

            //streamBytes = report.Render("PDF", null, out mimetype, out encoding, out filenameExtension, out streamids, out warnings);

            //return File(streamBytes, mimetype, $"{reportName}.{filenameExtension}");
        }


    }
}
