/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.quantlib;

public class OptionletVolatilityStructure {
  private transient long swigCPtr;
  protected transient boolean swigCMemOwn;

  protected OptionletVolatilityStructure(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(OptionletVolatilityStructure obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        QuantLibJNI.delete_OptionletVolatilityStructure(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public SWIGTYPE_p_OptionletVolatilityStructure __deref__() {
    long cPtr = QuantLibJNI.OptionletVolatilityStructure___deref__(swigCPtr, this);
    return (cPtr == 0) ? null : new SWIGTYPE_p_OptionletVolatilityStructure(cPtr, false);
  }

  public boolean isNull() {
    return QuantLibJNI.OptionletVolatilityStructure_isNull(swigCPtr, this);
  }

  public Observable asObservable() {
    return new Observable(QuantLibJNI.OptionletVolatilityStructure_asObservable(swigCPtr, this), true);
  }

  public OptionletVolatilityStructure() {
    this(QuantLibJNI.new_OptionletVolatilityStructure(), true);
  }

  public Date referenceDate() {
    return new Date(QuantLibJNI.OptionletVolatilityStructure_referenceDate(swigCPtr, this), true);
  }

  public DayCounter dayCounter() {
    return new DayCounter(QuantLibJNI.OptionletVolatilityStructure_dayCounter(swigCPtr, this), true);
  }

  public Calendar calendar() {
    return new Calendar(QuantLibJNI.OptionletVolatilityStructure_calendar(swigCPtr, this), true);
  }

  public Date maxDate() {
    return new Date(QuantLibJNI.OptionletVolatilityStructure_maxDate(swigCPtr, this), true);
  }

  public double maxTime() {
    return QuantLibJNI.OptionletVolatilityStructure_maxTime(swigCPtr, this);
  }

  public double minStrike() {
    return QuantLibJNI.OptionletVolatilityStructure_minStrike(swigCPtr, this);
  }

  public double maxStrike() {
    return QuantLibJNI.OptionletVolatilityStructure_maxStrike(swigCPtr, this);
  }

  public double volatility(Date arg0, double strike, boolean extrapolate) {
    return QuantLibJNI.OptionletVolatilityStructure_volatility__SWIG_0(swigCPtr, this, Date.getCPtr(arg0), arg0, strike, extrapolate);
  }

  public double volatility(Date arg0, double strike) {
    return QuantLibJNI.OptionletVolatilityStructure_volatility__SWIG_1(swigCPtr, this, Date.getCPtr(arg0), arg0, strike);
  }

  public double volatility(double arg0, double strike, boolean extrapolate) {
    return QuantLibJNI.OptionletVolatilityStructure_volatility__SWIG_2(swigCPtr, this, arg0, strike, extrapolate);
  }

  public double volatility(double arg0, double strike) {
    return QuantLibJNI.OptionletVolatilityStructure_volatility__SWIG_3(swigCPtr, this, arg0, strike);
  }

  public double blackVariance(Date arg0, double strike, boolean extrapolate) {
    return QuantLibJNI.OptionletVolatilityStructure_blackVariance__SWIG_0(swigCPtr, this, Date.getCPtr(arg0), arg0, strike, extrapolate);
  }

  public double blackVariance(Date arg0, double strike) {
    return QuantLibJNI.OptionletVolatilityStructure_blackVariance__SWIG_1(swigCPtr, this, Date.getCPtr(arg0), arg0, strike);
  }

  public double blackVariance(double arg0, double strike, boolean extrapolate) {
    return QuantLibJNI.OptionletVolatilityStructure_blackVariance__SWIG_2(swigCPtr, this, arg0, strike, extrapolate);
  }

  public double blackVariance(double arg0, double strike) {
    return QuantLibJNI.OptionletVolatilityStructure_blackVariance__SWIG_3(swigCPtr, this, arg0, strike);
  }

  public void enableExtrapolation() {
    QuantLibJNI.OptionletVolatilityStructure_enableExtrapolation(swigCPtr, this);
  }

  public void disableExtrapolation() {
    QuantLibJNI.OptionletVolatilityStructure_disableExtrapolation(swigCPtr, this);
  }

  public boolean allowsExtrapolation() {
    return QuantLibJNI.OptionletVolatilityStructure_allowsExtrapolation(swigCPtr, this);
  }

}
