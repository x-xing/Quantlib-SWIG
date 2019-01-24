/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.quantlib;

public class DefaultProbabilityTermStructure {
  private transient long swigCPtr;
  protected transient boolean swigCMemOwn;

  protected DefaultProbabilityTermStructure(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(DefaultProbabilityTermStructure obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        QuantLibJNI.delete_DefaultProbabilityTermStructure(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public SWIGTYPE_p_DefaultProbabilityTermStructure __deref__() {
    long cPtr = QuantLibJNI.DefaultProbabilityTermStructure___deref__(swigCPtr, this);
    return (cPtr == 0) ? null : new SWIGTYPE_p_DefaultProbabilityTermStructure(cPtr, false);
  }

  public boolean isNull() {
    return QuantLibJNI.DefaultProbabilityTermStructure_isNull(swigCPtr, this);
  }

  public Observable asObservable() {
    return new Observable(QuantLibJNI.DefaultProbabilityTermStructure_asObservable(swigCPtr, this), true);
  }

  public DefaultProbabilityTermStructure() {
    this(QuantLibJNI.new_DefaultProbabilityTermStructure(), true);
  }

  public DayCounter dayCounter() {
    return new DayCounter(QuantLibJNI.DefaultProbabilityTermStructure_dayCounter(swigCPtr, this), true);
  }

  public Calendar calendar() {
    return new Calendar(QuantLibJNI.DefaultProbabilityTermStructure_calendar(swigCPtr, this), true);
  }

  public Date referenceDate() {
    return new Date(QuantLibJNI.DefaultProbabilityTermStructure_referenceDate(swigCPtr, this), true);
  }

  public Date maxDate() {
    return new Date(QuantLibJNI.DefaultProbabilityTermStructure_maxDate(swigCPtr, this), true);
  }

  public double maxTime() {
    return QuantLibJNI.DefaultProbabilityTermStructure_maxTime(swigCPtr, this);
  }

  public double defaultProbability(Date arg0, boolean extrapolate) {
    return QuantLibJNI.DefaultProbabilityTermStructure_defaultProbability__SWIG_0(swigCPtr, this, Date.getCPtr(arg0), arg0, extrapolate);
  }

  public double defaultProbability(Date arg0) {
    return QuantLibJNI.DefaultProbabilityTermStructure_defaultProbability__SWIG_1(swigCPtr, this, Date.getCPtr(arg0), arg0);
  }

  public double defaultProbability(double arg0, boolean extrapolate) {
    return QuantLibJNI.DefaultProbabilityTermStructure_defaultProbability__SWIG_2(swigCPtr, this, arg0, extrapolate);
  }

  public double defaultProbability(double arg0) {
    return QuantLibJNI.DefaultProbabilityTermStructure_defaultProbability__SWIG_3(swigCPtr, this, arg0);
  }

  public double defaultProbability(Date arg0, Date arg1, boolean extrapolate) {
    return QuantLibJNI.DefaultProbabilityTermStructure_defaultProbability__SWIG_4(swigCPtr, this, Date.getCPtr(arg0), arg0, Date.getCPtr(arg1), arg1, extrapolate);
  }

  public double defaultProbability(Date arg0, Date arg1) {
    return QuantLibJNI.DefaultProbabilityTermStructure_defaultProbability__SWIG_5(swigCPtr, this, Date.getCPtr(arg0), arg0, Date.getCPtr(arg1), arg1);
  }

  public double defaultProbability(double arg0, double arg1, boolean extrapolate) {
    return QuantLibJNI.DefaultProbabilityTermStructure_defaultProbability__SWIG_6(swigCPtr, this, arg0, arg1, extrapolate);
  }

  public double defaultProbability(double arg0, double arg1) {
    return QuantLibJNI.DefaultProbabilityTermStructure_defaultProbability__SWIG_7(swigCPtr, this, arg0, arg1);
  }

  public double survivalProbability(Date arg0, boolean extrapolate) {
    return QuantLibJNI.DefaultProbabilityTermStructure_survivalProbability__SWIG_0(swigCPtr, this, Date.getCPtr(arg0), arg0, extrapolate);
  }

  public double survivalProbability(Date arg0) {
    return QuantLibJNI.DefaultProbabilityTermStructure_survivalProbability__SWIG_1(swigCPtr, this, Date.getCPtr(arg0), arg0);
  }

  public double survivalProbability(double arg0, boolean extrapolate) {
    return QuantLibJNI.DefaultProbabilityTermStructure_survivalProbability__SWIG_2(swigCPtr, this, arg0, extrapolate);
  }

  public double survivalProbability(double arg0) {
    return QuantLibJNI.DefaultProbabilityTermStructure_survivalProbability__SWIG_3(swigCPtr, this, arg0);
  }

  public double defaultDensity(Date arg0, boolean extrapolate) {
    return QuantLibJNI.DefaultProbabilityTermStructure_defaultDensity__SWIG_0(swigCPtr, this, Date.getCPtr(arg0), arg0, extrapolate);
  }

  public double defaultDensity(Date arg0) {
    return QuantLibJNI.DefaultProbabilityTermStructure_defaultDensity__SWIG_1(swigCPtr, this, Date.getCPtr(arg0), arg0);
  }

  public double defaultDensity(double arg0, boolean extrapolate) {
    return QuantLibJNI.DefaultProbabilityTermStructure_defaultDensity__SWIG_2(swigCPtr, this, arg0, extrapolate);
  }

  public double defaultDensity(double arg0) {
    return QuantLibJNI.DefaultProbabilityTermStructure_defaultDensity__SWIG_3(swigCPtr, this, arg0);
  }

  public double hazardRate(Date arg0, boolean extrapolate) {
    return QuantLibJNI.DefaultProbabilityTermStructure_hazardRate__SWIG_0(swigCPtr, this, Date.getCPtr(arg0), arg0, extrapolate);
  }

  public double hazardRate(Date arg0) {
    return QuantLibJNI.DefaultProbabilityTermStructure_hazardRate__SWIG_1(swigCPtr, this, Date.getCPtr(arg0), arg0);
  }

  public double hazardRate(double arg0, boolean extrapolate) {
    return QuantLibJNI.DefaultProbabilityTermStructure_hazardRate__SWIG_2(swigCPtr, this, arg0, extrapolate);
  }

  public double hazardRate(double arg0) {
    return QuantLibJNI.DefaultProbabilityTermStructure_hazardRate__SWIG_3(swigCPtr, this, arg0);
  }

  public void enableExtrapolation() {
    QuantLibJNI.DefaultProbabilityTermStructure_enableExtrapolation(swigCPtr, this);
  }

  public void disableExtrapolation() {
    QuantLibJNI.DefaultProbabilityTermStructure_disableExtrapolation(swigCPtr, this);
  }

  public boolean allowsExtrapolation() {
    return QuantLibJNI.DefaultProbabilityTermStructure_allowsExtrapolation(swigCPtr, this);
  }

}