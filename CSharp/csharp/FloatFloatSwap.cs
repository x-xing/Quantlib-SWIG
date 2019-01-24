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

public class FloatFloatSwap : Swap {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FloatFloatSwap(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.FloatFloatSwap_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FloatFloatSwap obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FloatFloatSwap() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_FloatFloatSwap(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public FloatFloatSwap(_VanillaSwap.Type type, DoubleVector nominal1, DoubleVector nominal2, Schedule schedule1, InterestRateIndex indexPtr1, DayCounter dayCount1, Schedule schedule2, InterestRateIndex indexPtr2, DayCounter dayCount2, bool intermediateCapitalExchange, bool finalCapitalExchange, DoubleVector gearing1, DoubleVector spread1, DoubleVector cappedRate1, DoubleVector flooredRate1, DoubleVector gearing2, DoubleVector spread2, DoubleVector cappedRate2, DoubleVector flooredRate2, BusinessDayConvention paymentConvention1, BusinessDayConvention paymentConvention2) : this(NQuantLibcPINVOKE.new_FloatFloatSwap__SWIG_0((int)type, DoubleVector.getCPtr(nominal1), DoubleVector.getCPtr(nominal2), Schedule.getCPtr(schedule1), InterestRateIndex.getCPtr(indexPtr1), DayCounter.getCPtr(dayCount1), Schedule.getCPtr(schedule2), InterestRateIndex.getCPtr(indexPtr2), DayCounter.getCPtr(dayCount2), intermediateCapitalExchange, finalCapitalExchange, DoubleVector.getCPtr(gearing1), DoubleVector.getCPtr(spread1), DoubleVector.getCPtr(cappedRate1), DoubleVector.getCPtr(flooredRate1), DoubleVector.getCPtr(gearing2), DoubleVector.getCPtr(spread2), DoubleVector.getCPtr(cappedRate2), DoubleVector.getCPtr(flooredRate2), (int)paymentConvention1, (int)paymentConvention2), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public FloatFloatSwap(_VanillaSwap.Type type, DoubleVector nominal1, DoubleVector nominal2, Schedule schedule1, InterestRateIndex indexPtr1, DayCounter dayCount1, Schedule schedule2, InterestRateIndex indexPtr2, DayCounter dayCount2, bool intermediateCapitalExchange, bool finalCapitalExchange, DoubleVector gearing1, DoubleVector spread1, DoubleVector cappedRate1, DoubleVector flooredRate1, DoubleVector gearing2, DoubleVector spread2, DoubleVector cappedRate2, DoubleVector flooredRate2, BusinessDayConvention paymentConvention1) : this(NQuantLibcPINVOKE.new_FloatFloatSwap__SWIG_1((int)type, DoubleVector.getCPtr(nominal1), DoubleVector.getCPtr(nominal2), Schedule.getCPtr(schedule1), InterestRateIndex.getCPtr(indexPtr1), DayCounter.getCPtr(dayCount1), Schedule.getCPtr(schedule2), InterestRateIndex.getCPtr(indexPtr2), DayCounter.getCPtr(dayCount2), intermediateCapitalExchange, finalCapitalExchange, DoubleVector.getCPtr(gearing1), DoubleVector.getCPtr(spread1), DoubleVector.getCPtr(cappedRate1), DoubleVector.getCPtr(flooredRate1), DoubleVector.getCPtr(gearing2), DoubleVector.getCPtr(spread2), DoubleVector.getCPtr(cappedRate2), DoubleVector.getCPtr(flooredRate2), (int)paymentConvention1), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public FloatFloatSwap(_VanillaSwap.Type type, DoubleVector nominal1, DoubleVector nominal2, Schedule schedule1, InterestRateIndex indexPtr1, DayCounter dayCount1, Schedule schedule2, InterestRateIndex indexPtr2, DayCounter dayCount2, bool intermediateCapitalExchange, bool finalCapitalExchange, DoubleVector gearing1, DoubleVector spread1, DoubleVector cappedRate1, DoubleVector flooredRate1, DoubleVector gearing2, DoubleVector spread2, DoubleVector cappedRate2, DoubleVector flooredRate2) : this(NQuantLibcPINVOKE.new_FloatFloatSwap__SWIG_2((int)type, DoubleVector.getCPtr(nominal1), DoubleVector.getCPtr(nominal2), Schedule.getCPtr(schedule1), InterestRateIndex.getCPtr(indexPtr1), DayCounter.getCPtr(dayCount1), Schedule.getCPtr(schedule2), InterestRateIndex.getCPtr(indexPtr2), DayCounter.getCPtr(dayCount2), intermediateCapitalExchange, finalCapitalExchange, DoubleVector.getCPtr(gearing1), DoubleVector.getCPtr(spread1), DoubleVector.getCPtr(cappedRate1), DoubleVector.getCPtr(flooredRate1), DoubleVector.getCPtr(gearing2), DoubleVector.getCPtr(spread2), DoubleVector.getCPtr(cappedRate2), DoubleVector.getCPtr(flooredRate2)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public FloatFloatSwap(_VanillaSwap.Type type, DoubleVector nominal1, DoubleVector nominal2, Schedule schedule1, InterestRateIndex indexPtr1, DayCounter dayCount1, Schedule schedule2, InterestRateIndex indexPtr2, DayCounter dayCount2, bool intermediateCapitalExchange, bool finalCapitalExchange, DoubleVector gearing1, DoubleVector spread1, DoubleVector cappedRate1, DoubleVector flooredRate1, DoubleVector gearing2, DoubleVector spread2, DoubleVector cappedRate2) : this(NQuantLibcPINVOKE.new_FloatFloatSwap__SWIG_3((int)type, DoubleVector.getCPtr(nominal1), DoubleVector.getCPtr(nominal2), Schedule.getCPtr(schedule1), InterestRateIndex.getCPtr(indexPtr1), DayCounter.getCPtr(dayCount1), Schedule.getCPtr(schedule2), InterestRateIndex.getCPtr(indexPtr2), DayCounter.getCPtr(dayCount2), intermediateCapitalExchange, finalCapitalExchange, DoubleVector.getCPtr(gearing1), DoubleVector.getCPtr(spread1), DoubleVector.getCPtr(cappedRate1), DoubleVector.getCPtr(flooredRate1), DoubleVector.getCPtr(gearing2), DoubleVector.getCPtr(spread2), DoubleVector.getCPtr(cappedRate2)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public FloatFloatSwap(_VanillaSwap.Type type, DoubleVector nominal1, DoubleVector nominal2, Schedule schedule1, InterestRateIndex indexPtr1, DayCounter dayCount1, Schedule schedule2, InterestRateIndex indexPtr2, DayCounter dayCount2, bool intermediateCapitalExchange, bool finalCapitalExchange, DoubleVector gearing1, DoubleVector spread1, DoubleVector cappedRate1, DoubleVector flooredRate1, DoubleVector gearing2, DoubleVector spread2) : this(NQuantLibcPINVOKE.new_FloatFloatSwap__SWIG_4((int)type, DoubleVector.getCPtr(nominal1), DoubleVector.getCPtr(nominal2), Schedule.getCPtr(schedule1), InterestRateIndex.getCPtr(indexPtr1), DayCounter.getCPtr(dayCount1), Schedule.getCPtr(schedule2), InterestRateIndex.getCPtr(indexPtr2), DayCounter.getCPtr(dayCount2), intermediateCapitalExchange, finalCapitalExchange, DoubleVector.getCPtr(gearing1), DoubleVector.getCPtr(spread1), DoubleVector.getCPtr(cappedRate1), DoubleVector.getCPtr(flooredRate1), DoubleVector.getCPtr(gearing2), DoubleVector.getCPtr(spread2)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public FloatFloatSwap(_VanillaSwap.Type type, DoubleVector nominal1, DoubleVector nominal2, Schedule schedule1, InterestRateIndex indexPtr1, DayCounter dayCount1, Schedule schedule2, InterestRateIndex indexPtr2, DayCounter dayCount2, bool intermediateCapitalExchange, bool finalCapitalExchange, DoubleVector gearing1, DoubleVector spread1, DoubleVector cappedRate1, DoubleVector flooredRate1, DoubleVector gearing2) : this(NQuantLibcPINVOKE.new_FloatFloatSwap__SWIG_5((int)type, DoubleVector.getCPtr(nominal1), DoubleVector.getCPtr(nominal2), Schedule.getCPtr(schedule1), InterestRateIndex.getCPtr(indexPtr1), DayCounter.getCPtr(dayCount1), Schedule.getCPtr(schedule2), InterestRateIndex.getCPtr(indexPtr2), DayCounter.getCPtr(dayCount2), intermediateCapitalExchange, finalCapitalExchange, DoubleVector.getCPtr(gearing1), DoubleVector.getCPtr(spread1), DoubleVector.getCPtr(cappedRate1), DoubleVector.getCPtr(flooredRate1), DoubleVector.getCPtr(gearing2)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public FloatFloatSwap(_VanillaSwap.Type type, DoubleVector nominal1, DoubleVector nominal2, Schedule schedule1, InterestRateIndex indexPtr1, DayCounter dayCount1, Schedule schedule2, InterestRateIndex indexPtr2, DayCounter dayCount2, bool intermediateCapitalExchange, bool finalCapitalExchange, DoubleVector gearing1, DoubleVector spread1, DoubleVector cappedRate1, DoubleVector flooredRate1) : this(NQuantLibcPINVOKE.new_FloatFloatSwap__SWIG_6((int)type, DoubleVector.getCPtr(nominal1), DoubleVector.getCPtr(nominal2), Schedule.getCPtr(schedule1), InterestRateIndex.getCPtr(indexPtr1), DayCounter.getCPtr(dayCount1), Schedule.getCPtr(schedule2), InterestRateIndex.getCPtr(indexPtr2), DayCounter.getCPtr(dayCount2), intermediateCapitalExchange, finalCapitalExchange, DoubleVector.getCPtr(gearing1), DoubleVector.getCPtr(spread1), DoubleVector.getCPtr(cappedRate1), DoubleVector.getCPtr(flooredRate1)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public FloatFloatSwap(_VanillaSwap.Type type, DoubleVector nominal1, DoubleVector nominal2, Schedule schedule1, InterestRateIndex indexPtr1, DayCounter dayCount1, Schedule schedule2, InterestRateIndex indexPtr2, DayCounter dayCount2, bool intermediateCapitalExchange, bool finalCapitalExchange, DoubleVector gearing1, DoubleVector spread1, DoubleVector cappedRate1) : this(NQuantLibcPINVOKE.new_FloatFloatSwap__SWIG_7((int)type, DoubleVector.getCPtr(nominal1), DoubleVector.getCPtr(nominal2), Schedule.getCPtr(schedule1), InterestRateIndex.getCPtr(indexPtr1), DayCounter.getCPtr(dayCount1), Schedule.getCPtr(schedule2), InterestRateIndex.getCPtr(indexPtr2), DayCounter.getCPtr(dayCount2), intermediateCapitalExchange, finalCapitalExchange, DoubleVector.getCPtr(gearing1), DoubleVector.getCPtr(spread1), DoubleVector.getCPtr(cappedRate1)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public FloatFloatSwap(_VanillaSwap.Type type, DoubleVector nominal1, DoubleVector nominal2, Schedule schedule1, InterestRateIndex indexPtr1, DayCounter dayCount1, Schedule schedule2, InterestRateIndex indexPtr2, DayCounter dayCount2, bool intermediateCapitalExchange, bool finalCapitalExchange, DoubleVector gearing1, DoubleVector spread1) : this(NQuantLibcPINVOKE.new_FloatFloatSwap__SWIG_8((int)type, DoubleVector.getCPtr(nominal1), DoubleVector.getCPtr(nominal2), Schedule.getCPtr(schedule1), InterestRateIndex.getCPtr(indexPtr1), DayCounter.getCPtr(dayCount1), Schedule.getCPtr(schedule2), InterestRateIndex.getCPtr(indexPtr2), DayCounter.getCPtr(dayCount2), intermediateCapitalExchange, finalCapitalExchange, DoubleVector.getCPtr(gearing1), DoubleVector.getCPtr(spread1)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public FloatFloatSwap(_VanillaSwap.Type type, DoubleVector nominal1, DoubleVector nominal2, Schedule schedule1, InterestRateIndex indexPtr1, DayCounter dayCount1, Schedule schedule2, InterestRateIndex indexPtr2, DayCounter dayCount2, bool intermediateCapitalExchange, bool finalCapitalExchange, DoubleVector gearing1) : this(NQuantLibcPINVOKE.new_FloatFloatSwap__SWIG_9((int)type, DoubleVector.getCPtr(nominal1), DoubleVector.getCPtr(nominal2), Schedule.getCPtr(schedule1), InterestRateIndex.getCPtr(indexPtr1), DayCounter.getCPtr(dayCount1), Schedule.getCPtr(schedule2), InterestRateIndex.getCPtr(indexPtr2), DayCounter.getCPtr(dayCount2), intermediateCapitalExchange, finalCapitalExchange, DoubleVector.getCPtr(gearing1)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public FloatFloatSwap(_VanillaSwap.Type type, DoubleVector nominal1, DoubleVector nominal2, Schedule schedule1, InterestRateIndex indexPtr1, DayCounter dayCount1, Schedule schedule2, InterestRateIndex indexPtr2, DayCounter dayCount2, bool intermediateCapitalExchange, bool finalCapitalExchange) : this(NQuantLibcPINVOKE.new_FloatFloatSwap__SWIG_10((int)type, DoubleVector.getCPtr(nominal1), DoubleVector.getCPtr(nominal2), Schedule.getCPtr(schedule1), InterestRateIndex.getCPtr(indexPtr1), DayCounter.getCPtr(dayCount1), Schedule.getCPtr(schedule2), InterestRateIndex.getCPtr(indexPtr2), DayCounter.getCPtr(dayCount2), intermediateCapitalExchange, finalCapitalExchange), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public FloatFloatSwap(_VanillaSwap.Type type, DoubleVector nominal1, DoubleVector nominal2, Schedule schedule1, InterestRateIndex indexPtr1, DayCounter dayCount1, Schedule schedule2, InterestRateIndex indexPtr2, DayCounter dayCount2, bool intermediateCapitalExchange) : this(NQuantLibcPINVOKE.new_FloatFloatSwap__SWIG_11((int)type, DoubleVector.getCPtr(nominal1), DoubleVector.getCPtr(nominal2), Schedule.getCPtr(schedule1), InterestRateIndex.getCPtr(indexPtr1), DayCounter.getCPtr(dayCount1), Schedule.getCPtr(schedule2), InterestRateIndex.getCPtr(indexPtr2), DayCounter.getCPtr(dayCount2), intermediateCapitalExchange), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public FloatFloatSwap(_VanillaSwap.Type type, DoubleVector nominal1, DoubleVector nominal2, Schedule schedule1, InterestRateIndex indexPtr1, DayCounter dayCount1, Schedule schedule2, InterestRateIndex indexPtr2, DayCounter dayCount2) : this(NQuantLibcPINVOKE.new_FloatFloatSwap__SWIG_12((int)type, DoubleVector.getCPtr(nominal1), DoubleVector.getCPtr(nominal2), Schedule.getCPtr(schedule1), InterestRateIndex.getCPtr(indexPtr1), DayCounter.getCPtr(dayCount1), Schedule.getCPtr(schedule2), InterestRateIndex.getCPtr(indexPtr2), DayCounter.getCPtr(dayCount2)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
