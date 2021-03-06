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

public class RebatedExercise : Exercise {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal RebatedExercise(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.RebatedExercise_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RebatedExercise obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~RebatedExercise() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_RebatedExercise(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public RebatedExercise(Exercise exercise, DoubleVector rebates, uint rebateSettlementDays, Calendar rebatePaymentCalendar, BusinessDayConvention rebatePaymentConvention) : this(NQuantLibcPINVOKE.new_RebatedExercise__SWIG_0(Exercise.getCPtr(exercise), DoubleVector.getCPtr(rebates), rebateSettlementDays, Calendar.getCPtr(rebatePaymentCalendar), (int)rebatePaymentConvention), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public RebatedExercise(Exercise exercise, DoubleVector rebates, uint rebateSettlementDays, Calendar rebatePaymentCalendar) : this(NQuantLibcPINVOKE.new_RebatedExercise__SWIG_1(Exercise.getCPtr(exercise), DoubleVector.getCPtr(rebates), rebateSettlementDays, Calendar.getCPtr(rebatePaymentCalendar)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public RebatedExercise(Exercise exercise, DoubleVector rebates, uint rebateSettlementDays) : this(NQuantLibcPINVOKE.new_RebatedExercise__SWIG_2(Exercise.getCPtr(exercise), DoubleVector.getCPtr(rebates), rebateSettlementDays), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public RebatedExercise(Exercise exercise, DoubleVector rebates) : this(NQuantLibcPINVOKE.new_RebatedExercise__SWIG_3(Exercise.getCPtr(exercise), DoubleVector.getCPtr(rebates)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
