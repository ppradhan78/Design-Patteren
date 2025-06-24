// See https://aka.ms/new-console-template for more information
using PatientInfoBuilder.Builder;

PatientRecordBuilder patientRecordBuilder = new PatientRecordBuilder();
patientRecordBuilder.AddRiskFactorsInformation();
patientRecordBuilder.AddDemographicInformation();
patientRecordBuilder. AddClinicalInformation();
patientRecordBuilder.AddDocumentInformation();
patientRecordBuilder.AddPhysicianAdvisoryInformation();
var output =patientRecordBuilder.Build();

Console.WriteLine("Hello, World!");
