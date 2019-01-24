//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace QuantLib {

public class OvernightIndexedSwap : Swap {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal OvernightIndexedSwap(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.OvernightIndexedSwap_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(OvernightIndexedSwap obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~OvernightIndexedSwap() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_OvernightIndexedSwap(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public OvernightIndexedSwap(_OvernightIndexedSwap.Type type, double nominal, Schedule schedule, double fixedRate, DayCounter fixedDC, OvernightIndex overnightIndex, double spread, uint paymentLag, BusinessDayConvention paymentAdjustment, Calendar paymentCalendar, bool telescopicValueDates) : this(NQuantLibcPINVOKE.new_OvernightIndexedSwap__SWIG_0((int)type, nominal, Schedule.getCPtr(schedule), fixedRate, DayCounter.getCPtr(fixedDC), OvernightIndex.getCPtr(overnightIndex), spread, paymentLag, (int)paymentAdjustment, Calendar.getCPtr(paymentCalendar), telescopicValueDates), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public OvernightIndexedSwap(_OvernightIndexedSwap.Type type, double nominal, Schedule schedule, double fixedRate, DayCounter fixedDC, OvernightIndex overnightIndex, double spread, uint paymentLag, BusinessDayConvention paymentAdjustment, Calendar paymentCalendar) : this(NQuantLibcPINVOKE.new_OvernightIndexedSwap__SWIG_1((int)type, nominal, Schedule.getCPtr(schedule), fixedRate, DayCounter.getCPtr(fixedDC), OvernightIndex.getCPtr(overnightIndex), spread, paymentLag, (int)paymentAdjustment, Calendar.getCPtr(paymentCalendar)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public OvernightIndexedSwap(_OvernightIndexedSwap.Type type, double nominal, Schedule schedule, double fixedRate, DayCounter fixedDC, OvernightIndex overnightIndex, double spread, uint paymentLag, BusinessDayConvention paymentAdjustment) : this(NQuantLibcPINVOKE.new_OvernightIndexedSwap__SWIG_2((int)type, nominal, Schedule.getCPtr(schedule), fixedRate, DayCounter.getCPtr(fixedDC), OvernightIndex.getCPtr(overnightIndex), spread, paymentLag, (int)paymentAdjustment), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public OvernightIndexedSwap(_OvernightIndexedSwap.Type type, double nominal, Schedule schedule, double fixedRate, DayCounter fixedDC, OvernightIndex overnightIndex, double spread, uint paymentLag) : this(NQuantLibcPINVOKE.new_OvernightIndexedSwap__SWIG_3((int)type, nominal, Schedule.getCPtr(schedule), fixedRate, DayCounter.getCPtr(fixedDC), OvernightIndex.getCPtr(overnightIndex), spread, paymentLag), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public OvernightIndexedSwap(_OvernightIndexedSwap.Type type, double nominal, Schedule schedule, double fixedRate, DayCounter fixedDC, OvernightIndex overnightIndex, double spread) : this(NQuantLibcPINVOKE.new_OvernightIndexedSwap__SWIG_4((int)type, nominal, Schedule.getCPtr(schedule), fixedRate, DayCounter.getCPtr(fixedDC), OvernightIndex.getCPtr(overnightIndex), spread), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public OvernightIndexedSwap(_OvernightIndexedSwap.Type type, double nominal, Schedule schedule, double fixedRate, DayCounter fixedDC, OvernightIndex overnightIndex) : this(NQuantLibcPINVOKE.new_OvernightIndexedSwap__SWIG_5((int)type, nominal, Schedule.getCPtr(schedule), fixedRate, DayCounter.getCPtr(fixedDC), OvernightIndex.getCPtr(overnightIndex)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public OvernightIndexedSwap(_OvernightIndexedSwap.Type type, DoubleVector nominals, Schedule schedule, double fixedRate, DayCounter fixedDC, OvernightIndex overnightIndex, double spread, uint paymentLag, BusinessDayConvention paymentAdjustment, Calendar paymentCalendar, bool telescopicValueDates) : this(NQuantLibcPINVOKE.new_OvernightIndexedSwap__SWIG_6((int)type, DoubleVector.getCPtr(nominals), Schedule.getCPtr(schedule), fixedRate, DayCounter.getCPtr(fixedDC), OvernightIndex.getCPtr(overnightIndex), spread, paymentLag, (int)paymentAdjustment, Calendar.getCPtr(paymentCalendar), telescopicValueDates), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public OvernightIndexedSwap(_OvernightIndexedSwap.Type type, DoubleVector nominals, Schedule schedule, double fixedRate, DayCounter fixedDC, OvernightIndex overnightIndex, double spread, uint paymentLag, BusinessDayConvention paymentAdjustment, Calendar paymentCalendar) : this(NQuantLibcPINVOKE.new_OvernightIndexedSwap__SWIG_7((int)type, DoubleVector.getCPtr(nominals), Schedule.getCPtr(schedule), fixedRate, DayCounter.getCPtr(fixedDC), OvernightIndex.getCPtr(overnightIndex), spread, paymentLag, (int)paymentAdjustment, Calendar.getCPtr(paymentCalendar)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public OvernightIndexedSwap(_OvernightIndexedSwap.Type type, DoubleVector nominals, Schedule schedule, double fixedRate, DayCounter fixedDC, OvernightIndex overnightIndex, double spread, uint paymentLag, BusinessDayConvention paymentAdjustment) : this(NQuantLibcPINVOKE.new_OvernightIndexedSwap__SWIG_8((int)type, DoubleVector.getCPtr(nominals), Schedule.getCPtr(schedule), fixedRate, DayCounter.getCPtr(fixedDC), OvernightIndex.getCPtr(overnightIndex), spread, paymentLag, (int)paymentAdjustment), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public OvernightIndexedSwap(_OvernightIndexedSwap.Type type, DoubleVector nominals, Schedule schedule, double fixedRate, DayCounter fixedDC, OvernightIndex overnightIndex, double spread, uint paymentLag) : this(NQuantLibcPINVOKE.new_OvernightIndexedSwap__SWIG_9((int)type, DoubleVector.getCPtr(nominals), Schedule.getCPtr(schedule), fixedRate, DayCounter.getCPtr(fixedDC), OvernightIndex.getCPtr(overnightIndex), spread, paymentLag), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public OvernightIndexedSwap(_OvernightIndexedSwap.Type type, DoubleVector nominals, Schedule schedule, double fixedRate, DayCounter fixedDC, OvernightIndex overnightIndex, double spread) : this(NQuantLibcPINVOKE.new_OvernightIndexedSwap__SWIG_10((int)type, DoubleVector.getCPtr(nominals), Schedule.getCPtr(schedule), fixedRate, DayCounter.getCPtr(fixedDC), OvernightIndex.getCPtr(overnightIndex), spread), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public OvernightIndexedSwap(_OvernightIndexedSwap.Type type, DoubleVector nominals, Schedule schedule, double fixedRate, DayCounter fixedDC, OvernightIndex overnightIndex) : this(NQuantLibcPINVOKE.new_OvernightIndexedSwap__SWIG_11((int)type, DoubleVector.getCPtr(nominals), Schedule.getCPtr(schedule), fixedRate, DayCounter.getCPtr(fixedDC), OvernightIndex.getCPtr(overnightIndex)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public double fixedLegBPS() {
    double ret = NQuantLibcPINVOKE.OvernightIndexedSwap_fixedLegBPS(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double fixedLegNPV() {
    double ret = NQuantLibcPINVOKE.OvernightIndexedSwap_fixedLegNPV(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double fairRate() {
    double ret = NQuantLibcPINVOKE.OvernightIndexedSwap_fairRate(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double overnightLegBPS() {
    double ret = NQuantLibcPINVOKE.OvernightIndexedSwap_overnightLegBPS(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double overnightLegNPV() {
    double ret = NQuantLibcPINVOKE.OvernightIndexedSwap_overnightLegNPV(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double fairSpread() {
    double ret = NQuantLibcPINVOKE.OvernightIndexedSwap_fairSpread(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public _OvernightIndexedSwap.Type type() {
    _OvernightIndexedSwap.Type ret = (_OvernightIndexedSwap.Type)NQuantLibcPINVOKE.OvernightIndexedSwap_type(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double nominal() {
    double ret = NQuantLibcPINVOKE.OvernightIndexedSwap_nominal(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public DoubleVector nominals() {
    DoubleVector ret = new DoubleVector(NQuantLibcPINVOKE.OvernightIndexedSwap_nominals(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Frequency paymentFrequency() {
    Frequency ret = (Frequency)NQuantLibcPINVOKE.OvernightIndexedSwap_paymentFrequency(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double fixedRate() {
    double ret = NQuantLibcPINVOKE.OvernightIndexedSwap_fixedRate(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public DayCounter fixedDayCount() {
    DayCounter ret = new DayCounter(NQuantLibcPINVOKE.OvernightIndexedSwap_fixedDayCount(swigCPtr), false);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double spread() {
    double ret = NQuantLibcPINVOKE.OvernightIndexedSwap_spread(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Leg fixedLeg() {
    Leg ret = new Leg(NQuantLibcPINVOKE.OvernightIndexedSwap_fixedLeg(swigCPtr), false);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Leg overnightLeg() {
    Leg ret = new Leg(NQuantLibcPINVOKE.OvernightIndexedSwap_overnightLeg(swigCPtr), false);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static readonly _OvernightIndexedSwap.Type Receiver = (_OvernightIndexedSwap.Type)NQuantLibcPINVOKE.OvernightIndexedSwap_Receiver_get();
  public static readonly _OvernightIndexedSwap.Type Payer = (_OvernightIndexedSwap.Type)NQuantLibcPINVOKE.OvernightIndexedSwap_Payer_get();
}

}