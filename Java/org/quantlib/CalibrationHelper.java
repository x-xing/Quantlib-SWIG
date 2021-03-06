/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.quantlib;

public class CalibrationHelper {
  private transient long swigCPtr;
  protected transient boolean swigCMemOwn;

  protected CalibrationHelper(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(CalibrationHelper obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        QuantLibJNI.delete_CalibrationHelper(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public _CalibrationHelper __deref__() {
    long cPtr = QuantLibJNI.CalibrationHelper___deref__(swigCPtr, this);
    return (cPtr == 0) ? null : new _CalibrationHelper(cPtr, false);
  }

  public boolean isNull() {
    return QuantLibJNI.CalibrationHelper_isNull(swigCPtr, this);
  }

  public Date swaptionExpiryDate() {
    return new Date(QuantLibJNI.CalibrationHelper_swaptionExpiryDate(swigCPtr, this), true);
  }

  public double swaptionStrike() {
    return QuantLibJNI.CalibrationHelper_swaptionStrike(swigCPtr, this);
  }

  public double swaptionNominal() {
    return QuantLibJNI.CalibrationHelper_swaptionNominal(swigCPtr, this);
  }

  public Date swaptionMaturityDate() {
    return new Date(QuantLibJNI.CalibrationHelper_swaptionMaturityDate(swigCPtr, this), true);
  }

  public CalibrationHelper() {
    this(QuantLibJNI.new_CalibrationHelper(), true);
  }

  public void setPricingEngine(PricingEngine engine) {
    QuantLibJNI.CalibrationHelper_setPricingEngine(swigCPtr, this, PricingEngine.getCPtr(engine), engine);
  }

  public double marketValue() {
    return QuantLibJNI.CalibrationHelper_marketValue(swigCPtr, this);
  }

  public double modelValue() {
    return QuantLibJNI.CalibrationHelper_modelValue(swigCPtr, this);
  }

  public double calibrationError() {
    return QuantLibJNI.CalibrationHelper_calibrationError(swigCPtr, this);
  }

  public double impliedVolatility(double targetValue, double accuracy, long maxEvaluations, double minVol, double maxVol) {
    return QuantLibJNI.CalibrationHelper_impliedVolatility(swigCPtr, this, targetValue, accuracy, maxEvaluations, minVol, maxVol);
  }

  public double blackPrice(double volatility) {
    return QuantLibJNI.CalibrationHelper_blackPrice(swigCPtr, this, volatility);
  }

  public QuoteHandle volatility() {
    return new QuoteHandle(QuantLibJNI.CalibrationHelper_volatility(swigCPtr, this), true);
  }

  public VolatilityType volatilityType() {
    return VolatilityType.swigToEnum(QuantLibJNI.CalibrationHelper_volatilityType(swigCPtr, this));
  }

  public final static _CalibrationHelper.CalibrationErrorType RelativePriceError = _CalibrationHelper.CalibrationErrorType.swigToEnum(QuantLibJNI.CalibrationHelper_RelativePriceError_get());
  public final static _CalibrationHelper.CalibrationErrorType PriceError = _CalibrationHelper.CalibrationErrorType.swigToEnum(QuantLibJNI.CalibrationHelper_PriceError_get());
  public final static _CalibrationHelper.CalibrationErrorType ImpliedVolError = _CalibrationHelper.CalibrationErrorType.swigToEnum(QuantLibJNI.CalibrationHelper_ImpliedVolError_get());
}
