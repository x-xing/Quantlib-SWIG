/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.quantlib;

public class JamshidianSwaptionEngine extends PricingEngine {
  private transient long swigCPtr;

  protected JamshidianSwaptionEngine(long cPtr, boolean cMemoryOwn) {
    super(QuantLibJNI.JamshidianSwaptionEngine_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(JamshidianSwaptionEngine obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        QuantLibJNI.delete_JamshidianSwaptionEngine(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public JamshidianSwaptionEngine(ShortRateModel model, YieldTermStructureHandle termStructure) {
    this(QuantLibJNI.new_JamshidianSwaptionEngine__SWIG_0(ShortRateModel.getCPtr(model), model, YieldTermStructureHandle.getCPtr(termStructure), termStructure), true);
  }

  public JamshidianSwaptionEngine(ShortRateModel model) {
    this(QuantLibJNI.new_JamshidianSwaptionEngine__SWIG_1(ShortRateModel.getCPtr(model), model), true);
  }

}