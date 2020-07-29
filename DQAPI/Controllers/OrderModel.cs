using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DQAPI.Controllers
{
    public class OrderModel
    {
      
            public int PKEY { get; set; }
            public int JobAccount_ID { get; set; }
            public int Trip_ID { get; set; }
            public int OldTrip_ID { get; set; }
            public int Status_ID { get; set; }
            public int Location_ID { get; set; }
            public int Unit_ID { get; set; }
            public string OrderNumber { get; set; }
            public string InvoiceNumber { get; set; }
            public string BuilderPONumber { get; set; }
            public string ShipTo { get; set; }
            public string Address { get; set; }
            public string Address2 { get; set; }
            public string SubDivision { get; set; }
            public int MapZone { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Zip { get; set; }
            public System.DateTime ReqDate { get; set; }
            public int ReqTime { get; set; }
            public int ShipmentNumber { get; set; }
            public int LoadSequence { get; set; }
            public decimal Cost { get; set; }
            public decimal Tax { get; set; }
            public decimal Amount { get; set; }
            public int Weight { get; set; }
            public int Volume { get; set; }
            public bool VolumeLock { get; set; }
            public int LoadRating { get; set; }
            public int LoadType { get; set; }
            public int Priority_ID { get; set; }
            public System.DateTime OrderDate { get; set; }
            public byte OrderChanged { get; set; }
            public System.DateTime ChgDate { get; set; }
            public byte Signed { get; set; }
            public bool Pictures { get; set; }
            public System.DateTime CancelDate { get; set; }
            public byte FillError { get; set; }
            public int WrittenBy_ID { get; set; }
            public int AssignedSalesperson { get; set; }
            public string PKImport { get; set; }
            public System.DateTime DeliveriedDate { get; set; }
            public bool StatusChanged { get; set; }
            public bool ReqDateChange { get; set; }
            public bool ReqTimeChange { get; set; }
            public bool TruckChange { get; set; }
            public bool RouteChanged { get; set; }
            public byte UpLoadToPhone { get; set; }
            public decimal DropLat { get; set; }
            public decimal DropLong { get; set; }
            public int GeoRadius { get; set; }
            public bool EMAILNOTIFICATION { get; set; }
            public string ReferenceNumber { get; set; }
            public bool AccountHold { get; set; }
            public int PreviousStatus { get; set; }
            public int TransferNumber { get; set; }
            public int OrderTypeID { get; set; }
            public bool Closed { get; set; }
            public int TruckTypeID { get; set; }
            public int Mileage { get; set; }
            public bool BackOrder { get; set; }
            public bool SpecialOrder { get; set; }
            public System.DateTime tsPHONEStatus { get; set; }
            public int CapacityLocationID { get; set; }
            public System.DateTime dTimeStamp { get; set; }
            public string ODTStatus { get; set; }
            public int OriginalLoadTimeID { get; set; }
            public System.DateTime OriginalDeliveryDate { get; set; }
            public int OriginalLocationID { get; set; }
            public bool HardTime { get; set; }
            public decimal Duration { get; set; }
            public System.DateTime ArrivalTime { get; set; }
            public System.DateTime DepartureTime { get; set; }
            public System.DateTime ETA { get; set; }
            public System.DateTime ETD { get; set; }
            public bool DeliveryLock { get; set; }
            public bool ShippingAddressNotJobAddress { get; set; }
            public System.DateTime UpLoadDate { get; set; }
            public System.DateTime RouteDate { get; set; }
            public System.DateTime ProductETA { get; set; }
            public System.DateTime CustomerRequestedDate { get; set; }
            public decimal CODAmountReceived { get; set; }
            public bool COD { get; set; }
            public bool Core { get; set; }
            public bool ItemsReturn { get; set; }
            public bool DefectReturn { get; set; }
            public int ShipVia_Id { get; set; }
            public System.DateTime ExpDelTime { get; set; }
            public System.DateTime ExpDelBegin { get; set; }
            public System.DateTime AdjustedETA { get; set; }
            public bool CustomerWebUpdate { get; set; }
            public System.DateTime TransferETA { get; set; }
            public System.DateTime SxWritebackNotesDate { get; set; }
            public int Length { get; set; }
            public int Length2 { get; set; }
            public string PayType { get; set; }
            public bool AddressChanged { get; set; }
            public int PrintTicketCount { get; set; }
            public byte ReImport { get; set; }
            public System.DateTime ScheduleLockDate { get; set; }
            public string WebOrderNumber { get; set; }
            public int TotQtyOrd { get; set; }
            public int TotQtyShp { get; set; }
            public int MilesFrom { get; set; }
            public bool InternalUse { get; set; }
        }
    }
