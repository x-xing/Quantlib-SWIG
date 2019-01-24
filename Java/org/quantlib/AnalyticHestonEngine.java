/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.quantlib;

public class AnalyticHestonEngine extends PricingEngine {
  private transient long swigCPtr;

  protected AnalyticHestonEngine(long cPtr, boolean cMemoryOwn) {
    super(QuantLibJNI.AnalyticHestonEngine_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(AnalyticHestonEngine obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        QuantLibJNI.delete_AnalyticHestonEngine(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public AnalyticHestonEngine(HestonModel model, long integrationOrder) {
    this(QuantLibJNI.new_AnalyticHestonEngine__SWIG_0(HestonModel.getCPtr(model), model, integrationOrder), true);
  }

  public AnalyticHestonEngine(HestonModel model) {
    this(QuantLibJNI.new_AnalyticHestonEngine__SWIG_1(HestonModel.getCPtr(model), model), true);
  }

  public AnalyticHestonEngine(HestonModel model, double relTolerance, long maxEvaluations) {
    this(QuantLibJNI.new_AnalyticHestonEngine__SWIG_2(HestonModel.getCPtr(model), model, relTolerance, maxEvaluations), true);
  }

}