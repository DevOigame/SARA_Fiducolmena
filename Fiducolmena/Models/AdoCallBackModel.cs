using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiducolmena.Models
{    
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Extras
    {
        public string IdState { get; set; }
        public string StateName { get; set; }
    }

    public class Image
    {
        public int Id { get; set; }
        public string ImageTypeId { get; set; }
        public string Image2 { get; set; }
    }

    public class Score
    {
        public int Id { get; set; }
        public string StateName { get; set; }
        public string StartingDate { get; set; }
        public string Observation { get; set; }
    }

    public class AdoCallBackModel
    {
        public string RequestNumber { get; set; }
        public string Uid { get; set; }
        public string StartingDate { get; set; }
        public string CreationDate { get; set; }
        public string CreationIP { get; set; }
        public int DocumentType { get; set; }
        public string IdNumber { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string FirstSurname { get; set; }
        public string SecondSurname { get; set; }
        public string Gender { get; set; }
        public string BirthDate { get; set; }
        public string Street { get; set; }
        public string CedulateCondition { get; set; }
        public string Spouse { get; set; }
        public string Home { get; set; }
        public string MaritalStatus { get; set; }
        public string DateOfIdentification { get; set; }
        public string DateOfDeath { get; set; }
        public string MarriageDate { get; set; }
        public string Instruction { get; set; }
        public string PlaceBirth { get; set; }
        public string Nationality { get; set; }
        public string MotherName { get; set; }
        public string FatherName { get; set; }
        public string HouseNumber { get; set; }
        public string Profession { get; set; }
        public string ExpeditionCity { get; set; }
        public string ExpeditionDepartment { get; set; }
        public string BirthCity { get; set; }
        public string BirthDepartment { get; set; }
        public int TransactionType { get; set; }
        public string TransactionTypeName { get; set; }
        public string IssueDate { get; set; }
        public string BarcodeText { get; set; }
        public string OcrTextSideOne { get; set; }
        public string OcrTextSideTwo { get; set; }
        public int SideOneWrongAttempts { get; set; }
        public int SideTwoWrongAttempts { get; set; }
        public bool FoundOnAdoAlert { get; set; }
        public string AdoProjectId { get; set; }
        public string TransactionId { get; set; }
        public string ProductId { get; set; }
        public bool ComparationFacesSuccesful { get; set; }
        public bool FaceFound { get; set; }
        public bool FaceDocumentFrontFound { get; set; }
        public bool BarcodeFound { get; set; }
        public decimal ResultComparationFaces { get; set; }
        public bool ComparationFacesAproved { get; set; }
        public Extras Extras { get; set; }
        public string NumberPhone { get; set; }
        public string CodFingerprint { get; set; }
        public string ResultQRCode { get; set; }
        public string DactilarCode { get; set; }
        public string ResponseControlList { get; set; }
        public List<Image> Images { get; set; }
        public List<string> SignedDocuments { get; set; }
        public List<Score> Scores { get; set; }
        public string Parameters { get; set; }
        public string StateSignatureDocument { get; set; }

        
    }


}