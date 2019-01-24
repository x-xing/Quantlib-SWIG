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

public class CubicZeroCurve : YieldTermStructure {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal CubicZeroCurve(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.CubicZeroCurve_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CubicZeroCurve obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CubicZeroCurve() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_CubicZeroCurve(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public CubicZeroCurve(DateVector dates, DoubleVector yields, DayCounter dayCounter, Calendar calendar, Cubic i, Compounding compounding, Frequency frequency) : this(NQuantLibcPINVOKE.new_CubicZeroCurve__SWIG_0(DateVector.getCPtr(dates), DoubleVector.getCPtr(yields), DayCounter.getCPtr(dayCounter), Calendar.getCPtr(calendar), Cubic.getCPtr(i), (int)compounding, (int)frequency), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public CubicZeroCurve(DateVector dates, DoubleVector yields, DayCounter dayCounter, Calendar calendar, Cubic i, Compounding compounding) : this(NQuantLibcPINVOKE.new_CubicZeroCurve__SWIG_1(DateVector.getCPtr(dates), DoubleVector.getCPtr(yields), DayCounter.getCPtr(dayCounter), Calendar.getCPtr(calendar), Cubic.getCPtr(i), (int)compounding), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public CubicZeroCurve(DateVector dates, DoubleVector yields, DayCounter dayCounter, Calendar calendar, Cubic i) : this(NQuantLibcPINVOKE.new_CubicZeroCurve__SWIG_2(DateVector.getCPtr(dates), DoubleVector.getCPtr(yields), DayCounter.getCPtr(dayCounter), Calendar.getCPtr(calendar), Cubic.getCPtr(i)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public CubicZeroCurve(DateVector dates, DoubleVector yields, DayCounter dayCounter, Calendar calendar) : this(NQuantLibcPINVOKE.new_CubicZeroCurve__SWIG_3(DateVector.getCPtr(dates), DoubleVector.getCPtr(yields), DayCounter.getCPtr(dayCounter), Calendar.getCPtr(calendar)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public CubicZeroCurve(DateVector dates, DoubleVector yields, DayCounter dayCounter) : this(NQuantLibcPINVOKE.new_CubicZeroCurve__SWIG_4(DateVector.getCPtr(dates), DoubleVector.getCPtr(yields), DayCounter.getCPtr(dayCounter)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public DoubleVector times() {
    DoubleVector ret = new DoubleVector(NQuantLibcPINVOKE.CubicZeroCurve_times(swigCPtr), false);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public DoubleVector data() {
    DoubleVector ret = new DoubleVector(NQuantLibcPINVOKE.CubicZeroCurve_data(swigCPtr), false);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public DateVector dates() {
    DateVector ret = new DateVector(NQuantLibcPINVOKE.CubicZeroCurve_dates(swigCPtr), false);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public DoubleVector zeroRates() {
    DoubleVector ret = new DoubleVector(NQuantLibcPINVOKE.CubicZeroCurve_zeroRates(swigCPtr), false);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public NodeVector nodes() {
    NodeVector ret = new NodeVector(NQuantLibcPINVOKE.CubicZeroCurve_nodes(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}