/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.quantlib;

public class MCDiscreteArithmeticAPEngine extends PricingEngine {
  private transient long swigCPtr;

  protected MCDiscreteArithmeticAPEngine(long cPtr, boolean cMemoryOwn) {
    super(QuantLibJNI.MCDiscreteArithmeticAPEngine_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(MCDiscreteArithmeticAPEngine obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        QuantLibJNI.delete_MCDiscreteArithmeticAPEngine(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public MCDiscreteArithmeticAPEngine(GeneralizedBlackScholesProcess process, String traits, boolean brownianBridge, boolean antitheticVariate, boolean controlVariate, int requiredSamples, double requiredTolerance, int maxSamples, int seed) {
    this(QuantLibJNI.new_MCDiscreteArithmeticAPEngine__SWIG_0(GeneralizedBlackScholesProcess.getCPtr(process), process, traits, brownianBridge, antitheticVariate, controlVariate, requiredSamples, requiredTolerance, maxSamples, seed), true);
  }

  public MCDiscreteArithmeticAPEngine(GeneralizedBlackScholesProcess process, String traits, boolean brownianBridge, boolean antitheticVariate, boolean controlVariate, int requiredSamples, double requiredTolerance, int maxSamples) {
    this(QuantLibJNI.new_MCDiscreteArithmeticAPEngine__SWIG_1(GeneralizedBlackScholesProcess.getCPtr(process), process, traits, brownianBridge, antitheticVariate, controlVariate, requiredSamples, requiredTolerance, maxSamples), true);
  }

  public MCDiscreteArithmeticAPEngine(GeneralizedBlackScholesProcess process, String traits, boolean brownianBridge, boolean antitheticVariate, boolean controlVariate, int requiredSamples, double requiredTolerance) {
    this(QuantLibJNI.new_MCDiscreteArithmeticAPEngine__SWIG_2(GeneralizedBlackScholesProcess.getCPtr(process), process, traits, brownianBridge, antitheticVariate, controlVariate, requiredSamples, requiredTolerance), true);
  }

  public MCDiscreteArithmeticAPEngine(GeneralizedBlackScholesProcess process, String traits, boolean brownianBridge, boolean antitheticVariate, boolean controlVariate, int requiredSamples) {
    this(QuantLibJNI.new_MCDiscreteArithmeticAPEngine__SWIG_3(GeneralizedBlackScholesProcess.getCPtr(process), process, traits, brownianBridge, antitheticVariate, controlVariate, requiredSamples), true);
  }

  public MCDiscreteArithmeticAPEngine(GeneralizedBlackScholesProcess process, String traits, boolean brownianBridge, boolean antitheticVariate, boolean controlVariate) {
    this(QuantLibJNI.new_MCDiscreteArithmeticAPEngine__SWIG_4(GeneralizedBlackScholesProcess.getCPtr(process), process, traits, brownianBridge, antitheticVariate, controlVariate), true);
  }

  public MCDiscreteArithmeticAPEngine(GeneralizedBlackScholesProcess process, String traits, boolean brownianBridge, boolean antitheticVariate) {
    this(QuantLibJNI.new_MCDiscreteArithmeticAPEngine__SWIG_5(GeneralizedBlackScholesProcess.getCPtr(process), process, traits, brownianBridge, antitheticVariate), true);
  }

  public MCDiscreteArithmeticAPEngine(GeneralizedBlackScholesProcess process, String traits, boolean brownianBridge) {
    this(QuantLibJNI.new_MCDiscreteArithmeticAPEngine__SWIG_6(GeneralizedBlackScholesProcess.getCPtr(process), process, traits, brownianBridge), true);
  }

  public MCDiscreteArithmeticAPEngine(GeneralizedBlackScholesProcess process, String traits) {
    this(QuantLibJNI.new_MCDiscreteArithmeticAPEngine__SWIG_7(GeneralizedBlackScholesProcess.getCPtr(process), process, traits), true);
  }

}
