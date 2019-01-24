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

public class CapFloorTermVolSurface : CapFloorTermVolatilityStructure {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal CapFloorTermVolSurface(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.CapFloorTermVolSurface_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CapFloorTermVolSurface obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CapFloorTermVolSurface() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_CapFloorTermVolSurface(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public CapFloorTermVolSurface(uint settlementDays, Calendar calendar, BusinessDayConvention bdc, PeriodVector optionTenors, DoubleVector strikes, QuoteHandleVectorVector quotes, DayCounter dc) : this(NQuantLibcPINVOKE.new_CapFloorTermVolSurface__SWIG_0(settlementDays, Calendar.getCPtr(calendar), (int)bdc, PeriodVector.getCPtr(optionTenors), DoubleVector.getCPtr(strikes), QuoteHandleVectorVector.getCPtr(quotes), DayCounter.getCPtr(dc)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public CapFloorTermVolSurface(uint settlementDays, Calendar calendar, BusinessDayConvention bdc, PeriodVector optionTenors, DoubleVector strikes, QuoteHandleVectorVector quotes) : this(NQuantLibcPINVOKE.new_CapFloorTermVolSurface__SWIG_1(settlementDays, Calendar.getCPtr(calendar), (int)bdc, PeriodVector.getCPtr(optionTenors), DoubleVector.getCPtr(strikes), QuoteHandleVectorVector.getCPtr(quotes)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public CapFloorTermVolSurface(Date settlementDate, Calendar calendar, BusinessDayConvention bdc, PeriodVector optionTenors, DoubleVector strikes, QuoteHandleVectorVector quotes, DayCounter dc) : this(NQuantLibcPINVOKE.new_CapFloorTermVolSurface__SWIG_2(Date.getCPtr(settlementDate), Calendar.getCPtr(calendar), (int)bdc, PeriodVector.getCPtr(optionTenors), DoubleVector.getCPtr(strikes), QuoteHandleVectorVector.getCPtr(quotes), DayCounter.getCPtr(dc)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public CapFloorTermVolSurface(Date settlementDate, Calendar calendar, BusinessDayConvention bdc, PeriodVector optionTenors, DoubleVector strikes, QuoteHandleVectorVector quotes) : this(NQuantLibcPINVOKE.new_CapFloorTermVolSurface__SWIG_3(Date.getCPtr(settlementDate), Calendar.getCPtr(calendar), (int)bdc, PeriodVector.getCPtr(optionTenors), DoubleVector.getCPtr(strikes), QuoteHandleVectorVector.getCPtr(quotes)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public CapFloorTermVolSurface(Date settlementDate, Calendar calendar, BusinessDayConvention bdc, PeriodVector optionTenors, DoubleVector strikes, Matrix volatilities, DayCounter dc) : this(NQuantLibcPINVOKE.new_CapFloorTermVolSurface__SWIG_4(Date.getCPtr(settlementDate), Calendar.getCPtr(calendar), (int)bdc, PeriodVector.getCPtr(optionTenors), DoubleVector.getCPtr(strikes), Matrix.getCPtr(volatilities), DayCounter.getCPtr(dc)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public CapFloorTermVolSurface(Date settlementDate, Calendar calendar, BusinessDayConvention bdc, PeriodVector optionTenors, DoubleVector strikes, Matrix volatilities) : this(NQuantLibcPINVOKE.new_CapFloorTermVolSurface__SWIG_5(Date.getCPtr(settlementDate), Calendar.getCPtr(calendar), (int)bdc, PeriodVector.getCPtr(optionTenors), DoubleVector.getCPtr(strikes), Matrix.getCPtr(volatilities)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public CapFloorTermVolSurface(uint settlementDays, Calendar calendar, BusinessDayConvention bdc, PeriodVector optionTenors, DoubleVector strikes, Matrix volatilities, DayCounter dc) : this(NQuantLibcPINVOKE.new_CapFloorTermVolSurface__SWIG_6(settlementDays, Calendar.getCPtr(calendar), (int)bdc, PeriodVector.getCPtr(optionTenors), DoubleVector.getCPtr(strikes), Matrix.getCPtr(volatilities), DayCounter.getCPtr(dc)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public CapFloorTermVolSurface(uint settlementDays, Calendar calendar, BusinessDayConvention bdc, PeriodVector optionTenors, DoubleVector strikes, Matrix volatilities) : this(NQuantLibcPINVOKE.new_CapFloorTermVolSurface__SWIG_7(settlementDays, Calendar.getCPtr(calendar), (int)bdc, PeriodVector.getCPtr(optionTenors), DoubleVector.getCPtr(strikes), Matrix.getCPtr(volatilities)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
