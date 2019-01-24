/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.quantlib;

public class ExchangeRateManager {
  private transient long swigCPtr;
  protected transient boolean swigCMemOwn;

  protected ExchangeRateManager(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(ExchangeRateManager obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        QuantLibJNI.delete_ExchangeRateManager(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public static ExchangeRateManager instance() {
    return new ExchangeRateManager(QuantLibJNI.ExchangeRateManager_instance(), false);
  }

  public void add(ExchangeRate arg0, Date startDate, Date endDate) {
    QuantLibJNI.ExchangeRateManager_add__SWIG_0(swigCPtr, this, ExchangeRate.getCPtr(arg0), arg0, Date.getCPtr(startDate), startDate, Date.getCPtr(endDate), endDate);
  }

  public void add(ExchangeRate arg0, Date startDate) {
    QuantLibJNI.ExchangeRateManager_add__SWIG_1(swigCPtr, this, ExchangeRate.getCPtr(arg0), arg0, Date.getCPtr(startDate), startDate);
  }

  public void add(ExchangeRate arg0) {
    QuantLibJNI.ExchangeRateManager_add__SWIG_2(swigCPtr, this, ExchangeRate.getCPtr(arg0), arg0);
  }

  public ExchangeRate lookup(Currency source, Currency target, Date date, ExchangeRate.Type type) {
    return new ExchangeRate(QuantLibJNI.ExchangeRateManager_lookup__SWIG_0(swigCPtr, this, Currency.getCPtr(source), source, Currency.getCPtr(target), target, Date.getCPtr(date), date, type.swigValue()), true);
  }

  public ExchangeRate lookup(Currency source, Currency target, Date date) {
    return new ExchangeRate(QuantLibJNI.ExchangeRateManager_lookup__SWIG_1(swigCPtr, this, Currency.getCPtr(source), source, Currency.getCPtr(target), target, Date.getCPtr(date), date), true);
  }

  public void clear() {
    QuantLibJNI.ExchangeRateManager_clear(swigCPtr, this);
  }

}
