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

public class DefaultDensityCurve : DefaultProbabilityTermStructure {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal DefaultDensityCurve(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.DefaultDensityCurve_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(DefaultDensityCurve obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~DefaultDensityCurve() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_DefaultDensityCurve(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public DefaultDensityCurve(DateVector dates, DoubleVector densities, DayCounter dayCounter, Calendar calendar, Linear i) : this(NQuantLibcPINVOKE.new_DefaultDensityCurve__SWIG_0(DateVector.getCPtr(dates), DoubleVector.getCPtr(densities), DayCounter.getCPtr(dayCounter), Calendar.getCPtr(calendar), Linear.getCPtr(i)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public DefaultDensityCurve(DateVector dates, DoubleVector densities, DayCounter dayCounter, Calendar calendar) : this(NQuantLibcPINVOKE.new_DefaultDensityCurve__SWIG_1(DateVector.getCPtr(dates), DoubleVector.getCPtr(densities), DayCounter.getCPtr(dayCounter), Calendar.getCPtr(calendar)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public DefaultDensityCurve(DateVector dates, DoubleVector densities, DayCounter dayCounter) : this(NQuantLibcPINVOKE.new_DefaultDensityCurve__SWIG_2(DateVector.getCPtr(dates), DoubleVector.getCPtr(densities), DayCounter.getCPtr(dayCounter)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public DateVector dates() {
    DateVector ret = new DateVector(NQuantLibcPINVOKE.DefaultDensityCurve_dates(swigCPtr), false);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public DoubleVector defaultDensities() {
    DoubleVector ret = new DoubleVector(NQuantLibcPINVOKE.DefaultDensityCurve_defaultDensities(swigCPtr), false);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public NodeVector nodes() {
    NodeVector ret = new NodeVector(NQuantLibcPINVOKE.DefaultDensityCurve_nodes(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
