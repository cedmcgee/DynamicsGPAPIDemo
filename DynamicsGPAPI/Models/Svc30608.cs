﻿using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc30608
    {
        public short Consts { get; set; }
        public string Contnbr { get; set; }
        public decimal Lnseqnbr { get; set; }
        public short ContractTransferStatus { get; set; }
        public DateTime ContractTransferDate { get; set; }
        public string Taxschid { get; set; }
        public short PriorityLevel { get; set; }
        public string Adrscode { get; set; }
        public decimal Noteindx { get; set; }
        public string Timezone { get; set; }
        public decimal Contprc { get; set; }
        public short Rencnttyp { get; set; }
        public string Renprcschd { get; set; }
        public decimal Pctcryfwd { get; set; }
        public DateTime Frzend { get; set; }
        public DateTime Frxstrt { get; set; }
        public decimal Mxincpct { get; set; }
        public decimal Blktim { get; set; }
        public decimal Valtim { get; set; }
        public short Dscpctam { get; set; }
        public decimal Comdlram { get; set; }
        public string Country { get; set; }
        public string Prcstat { get; set; }
        public string Pordnmbr { get; set; }
        public string Dscriptn { get; set; }
        public decimal Partpct { get; set; }
        public decimal Labpct { get; set; }
        public decimal Miscpct { get; set; }
        public decimal Pmmscpct { get; set; }
        public decimal Pmprtpct { get; set; }
        public decimal Pmlabpct { get; set; }
        public string Vendorid { get; set; }
        public decimal Retnagam { get; set; }
        public decimal Rtnbilld { get; set; }
        public string Slprsnid { get; set; }
        public string Commcode { get; set; }
        public short Comprcnt { get; set; }
        public DateTime Bilstrt { get; set; }
        public DateTime Bilend { get; set; }
        public short Billngth { get; set; }
        public short Bilprd { get; set; }
        public decimal Total { get; set; }
        public DateTime Frstbldte { get; set; }
        public decimal LastAmountBilled { get; set; }
        public DateTime Lstbldte { get; set; }
        public short Nbrcal { get; set; }
        public short Actcal { get; set; }
        public decimal Totvalcal { get; set; }
        public string Contact { get; set; }
        public string Curncyid { get; set; }
        public DateTime Nxtbldte { get; set; }
        public string Cnttype { get; set; }
        public string Pricshed { get; set; }
        public string Custnmbr { get; set; }
        public DateTime Entdte { get; set; }
        public decimal Minbil { get; set; }
        public decimal Maxbil { get; set; }
        public decimal Maxbill { get; set; }
        public byte Autoren { get; set; }
        public string Mstcntrct { get; set; }
        public string Srvtype { get; set; }
        public byte Bilfrret { get; set; }
        public decimal Totbil { get; set; }
        public byte Prepaid { get; set; }
        public short Bilondy { get; set; }
        public short Bilcyc { get; set; }
        public string Uofm { get; set; }
        public short Bilstat { get; set; }
        public DateTime Enttme { get; set; }
        public DateTime Strtdate { get; set; }
        public DateTime Enddate { get; set; }
        public DateTime Cntcovpd1 { get; set; }
        public DateTime Cntcovpd2 { get; set; }
        public DateTime Cntcovpd3 { get; set; }
        public DateTime Cntcovpd4 { get; set; }
        public DateTime Cntcovpd5 { get; set; }
        public DateTime Cntcovpd6 { get; set; }
        public DateTime Cntcovpd7 { get; set; }
        public DateTime ContractCoveragePeriod1 { get; set; }
        public DateTime ContractCoveragePeriod2 { get; set; }
        public DateTime ContractCoveragePeriod3 { get; set; }
        public DateTime ContractCoveragePeriod4 { get; set; }
        public DateTime ContractCoveragePeriod5 { get; set; }
        public DateTime ContractCoveragePeriod6 { get; set; }
        public DateTime ContractCoveragePeriod7 { get; set; }
        public byte Usecvpd1 { get; set; }
        public byte Usecvpd2 { get; set; }
        public byte Usecvpd3 { get; set; }
        public byte Usecvpd4 { get; set; }
        public byte Usecvpd5 { get; set; }
        public byte Usecvpd6 { get; set; }
        public byte Usecvpd7 { get; set; }
        public short ContractLength { get; set; }
        public short ContractPeriod { get; set; }
        public decimal InvoicedAmount { get; set; }
        public byte LiabiltiyReduction { get; set; }
        public decimal AmountToInvoice { get; set; }
        public decimal LiabilityAmount { get; set; }
        public decimal TotalLiabilityAmount { get; set; }
        public int Numofinv { get; set; }
        public short QuoteStatus { get; set; }
        public DateTime Quoexpda { get; set; }
        public byte CreditHold { get; set; }
        public string Taxexmt1 { get; set; }
        public string Taxexmt2 { get; set; }
        public byte NewPoRequired { get; set; }
        public string ContractRenewalContact { get; set; }
        public string SourceContractNumber { get; set; }
        public short SourceContractType { get; set; }
        public string ContractResponseTime { get; set; }
        public short LiabilityMonths { get; set; }
        public DateTime NextLiabilityDate { get; set; }
        public DateTime LastLiabilityDate { get; set; }
        public decimal TotalLiabilityBilled { get; set; }
        public decimal TotalUnit { get; set; }
        public string CreatedUserId { get; set; }
        public string SourceUserId { get; set; }
        public DateTime SvcContractSigned { get; set; }
        public short SvcLiabilityType { get; set; }
        public string Rettype { get; set; }
        public string LocationSegment { get; set; }
        public string BillToCustomer { get; set; }
        public byte CoverAll { get; set; }
        public byte Canceled { get; set; }
        public short Currnidx { get; set; }
        public string Ratetpid { get; set; }
        public string Exgtblid { get; set; }
        public decimal Xchgrate { get; set; }
        public DateTime Exchdate { get; set; }
        public short Decplacs { get; set; }
        public DateTime Time1 { get; set; }
        public short Ratecalc { get; set; }
        public short Viewmode { get; set; }
        public short Ismctrx { get; set; }
        public DateTime Expndate { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public decimal Origvaltim { get; set; }
        public decimal Orcomamt { get; set; }
        public decimal Origretnagam { get; set; }
        public decimal Origrtnbilld { get; set; }
        public decimal OriglastamountBilled { get; set; }
        public decimal Origtotal { get; set; }
        public decimal Origtotvalcal { get; set; }
        public decimal Origminbil { get; set; }
        public decimal Origmaxbil { get; set; }
        public decimal OriginatingMaxBillable { get; set; }
        public decimal Origtotbil { get; set; }
        public decimal OrigInvoicedAmount { get; set; }
        public decimal OrigAmountToInvoice { get; set; }
        public decimal OrigLiabilityAmount { get; set; }
        public decimal OrigTotLiabilityAmount { get; set; }
        public decimal OrigTotLiabBilled { get; set; }
        public decimal OriginatingTotalUnit { get; set; }
        public short SvcContractVersion { get; set; }
        public string SvcBillToAddressCode { get; set; }
        public short SvcBillingFrequency { get; set; }
        public int DexRowId { get; set; }
    }
}
