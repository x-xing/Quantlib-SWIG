/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.quantlib;

public class FdHullWhiteSwaptionEngine extends PricingEngine {
  private transient long swigCPtr;

  protected FdHullWhiteSwaptionEngine(long cPtr, boolean cMemoryOwn) {
    super(QuantLibJNI.FdHullWhiteSwaptionEngine_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(FdHullWhiteSwaptionEngine obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        QuantLibJNI.delete_FdHullWhiteSwaptionEngine(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public FdHullWhiteSwaptionEngine(ShortRateModel model, long tGrid, long xGrid, long dampingSteps, double invEps, FdmSchemeDesc schemeDesc) {
    this(QuantLibJNI.new_FdHullWhiteSwaptionEngine__SWIG_0(ShortRateModel.getCPtr(model), model, tGrid, xGrid, dampingSteps, invEps, FdmSchemeDesc.getCPtr(schemeDesc), schemeDesc), true);
  }

  public FdHullWhiteSwaptionEngine(ShortRateModel model, long tGrid, long xGrid, long dampingSteps, double invEps) {
    this(QuantLibJNI.new_FdHullWhiteSwaptionEngine__SWIG_1(ShortRateModel.getCPtr(model), model, tGrid, xGrid, dampingSteps, invEps), true);
  }

  public FdHullWhiteSwaptionEngine(ShortRateModel model, long tGrid, long xGrid, long dampingSteps) {
    this(QuantLibJNI.new_FdHullWhiteSwaptionEngine__SWIG_2(ShortRateModel.getCPtr(model), model, tGrid, xGrid, dampingSteps), true);
  }

  public FdHullWhiteSwaptionEngine(ShortRateModel model, long tGrid, long xGrid) {
    this(QuantLibJNI.new_FdHullWhiteSwaptionEngine__SWIG_3(ShortRateModel.getCPtr(model), model, tGrid, xGrid), true);
  }

  public FdHullWhiteSwaptionEngine(ShortRateModel model, long tGrid) {
    this(QuantLibJNI.new_FdHullWhiteSwaptionEngine__SWIG_4(ShortRateModel.getCPtr(model), model, tGrid), true);
  }

  public FdHullWhiteSwaptionEngine(ShortRateModel model) {
    this(QuantLibJNI.new_FdHullWhiteSwaptionEngine__SWIG_5(ShortRateModel.getCPtr(model), model), true);
  }

}
