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

public class FdHullWhiteSwaptionEngine : PricingEngine {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FdHullWhiteSwaptionEngine(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.FdHullWhiteSwaptionEngine_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FdHullWhiteSwaptionEngine obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FdHullWhiteSwaptionEngine() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_FdHullWhiteSwaptionEngine(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public FdHullWhiteSwaptionEngine(ShortRateModel model, uint tGrid, uint xGrid, uint dampingSteps, double invEps, FdmSchemeDesc schemeDesc) : this(NQuantLibcPINVOKE.new_FdHullWhiteSwaptionEngine__SWIG_0(ShortRateModel.getCPtr(model), tGrid, xGrid, dampingSteps, invEps, FdmSchemeDesc.getCPtr(schemeDesc)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public FdHullWhiteSwaptionEngine(ShortRateModel model, uint tGrid, uint xGrid, uint dampingSteps, double invEps) : this(NQuantLibcPINVOKE.new_FdHullWhiteSwaptionEngine__SWIG_1(ShortRateModel.getCPtr(model), tGrid, xGrid, dampingSteps, invEps), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public FdHullWhiteSwaptionEngine(ShortRateModel model, uint tGrid, uint xGrid, uint dampingSteps) : this(NQuantLibcPINVOKE.new_FdHullWhiteSwaptionEngine__SWIG_2(ShortRateModel.getCPtr(model), tGrid, xGrid, dampingSteps), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public FdHullWhiteSwaptionEngine(ShortRateModel model, uint tGrid, uint xGrid) : this(NQuantLibcPINVOKE.new_FdHullWhiteSwaptionEngine__SWIG_3(ShortRateModel.getCPtr(model), tGrid, xGrid), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public FdHullWhiteSwaptionEngine(ShortRateModel model, uint tGrid) : this(NQuantLibcPINVOKE.new_FdHullWhiteSwaptionEngine__SWIG_4(ShortRateModel.getCPtr(model), tGrid), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public FdHullWhiteSwaptionEngine(ShortRateModel model) : this(NQuantLibcPINVOKE.new_FdHullWhiteSwaptionEngine__SWIG_5(ShortRateModel.getCPtr(model)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

}

}