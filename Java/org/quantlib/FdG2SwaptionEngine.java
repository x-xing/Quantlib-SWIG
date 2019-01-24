/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.quantlib;

public class FdG2SwaptionEngine extends PricingEngine {
  private transient long swigCPtr;

  protected FdG2SwaptionEngine(long cPtr, boolean cMemoryOwn) {
    super(QuantLibJNI.FdG2SwaptionEngine_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(FdG2SwaptionEngine obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        QuantLibJNI.delete_FdG2SwaptionEngine(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public FdG2SwaptionEngine(ShortRateModel model, long tGrid, long xGrid, long yGrid, long dampingSteps, double invEps, FdmSchemeDesc schemeDesc) {
    this(QuantLibJNI.new_FdG2SwaptionEngine__SWIG_0(ShortRateModel.getCPtr(model), model, tGrid, xGrid, yGrid, dampingSteps, invEps, FdmSchemeDesc.getCPtr(schemeDesc), schemeDesc), true);
  }

  public FdG2SwaptionEngine(ShortRateModel model, long tGrid, long xGrid, long yGrid, long dampingSteps, double invEps) {
    this(QuantLibJNI.new_FdG2SwaptionEngine__SWIG_1(ShortRateModel.getCPtr(model), model, tGrid, xGrid, yGrid, dampingSteps, invEps), true);
  }

  public FdG2SwaptionEngine(ShortRateModel model, long tGrid, long xGrid, long yGrid, long dampingSteps) {
    this(QuantLibJNI.new_FdG2SwaptionEngine__SWIG_2(ShortRateModel.getCPtr(model), model, tGrid, xGrid, yGrid, dampingSteps), true);
  }

  public FdG2SwaptionEngine(ShortRateModel model, long tGrid, long xGrid, long yGrid) {
    this(QuantLibJNI.new_FdG2SwaptionEngine__SWIG_3(ShortRateModel.getCPtr(model), model, tGrid, xGrid, yGrid), true);
  }

  public FdG2SwaptionEngine(ShortRateModel model, long tGrid, long xGrid) {
    this(QuantLibJNI.new_FdG2SwaptionEngine__SWIG_4(ShortRateModel.getCPtr(model), model, tGrid, xGrid), true);
  }

  public FdG2SwaptionEngine(ShortRateModel model, long tGrid) {
    this(QuantLibJNI.new_FdG2SwaptionEngine__SWIG_5(ShortRateModel.getCPtr(model), model, tGrid), true);
  }

  public FdG2SwaptionEngine(ShortRateModel model) {
    this(QuantLibJNI.new_FdG2SwaptionEngine__SWIG_6(ShortRateModel.getCPtr(model), model), true);
  }

}
