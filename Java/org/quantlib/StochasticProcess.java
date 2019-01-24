/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.quantlib;

public class StochasticProcess {
  private transient long swigCPtr;
  protected transient boolean swigCMemOwn;

  protected StochasticProcess(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(StochasticProcess obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        QuantLibJNI.delete_StochasticProcess(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public SWIGTYPE_p_StochasticProcess __deref__() {
    long cPtr = QuantLibJNI.StochasticProcess___deref__(swigCPtr, this);
    return (cPtr == 0) ? null : new SWIGTYPE_p_StochasticProcess(cPtr, false);
  }

  public boolean isNull() {
    return QuantLibJNI.StochasticProcess_isNull(swigCPtr, this);
  }

  public Observable asObservable() {
    return new Observable(QuantLibJNI.StochasticProcess_asObservable(swigCPtr, this), true);
  }

  public StochasticProcess() {
    this(QuantLibJNI.new_StochasticProcess(), true);
  }

  public long size() {
    return QuantLibJNI.StochasticProcess_size(swigCPtr, this);
  }

  public long factors() {
    return QuantLibJNI.StochasticProcess_factors(swigCPtr, this);
  }

  public Array initialValues() {
    return new Array(QuantLibJNI.StochasticProcess_initialValues(swigCPtr, this), true);
  }

  public Array drift(double t, Array x) {
    return new Array(QuantLibJNI.StochasticProcess_drift(swigCPtr, this, t, Array.getCPtr(x), x), true);
  }

  public Matrix diffusion(double t, Array x) {
    return new Matrix(QuantLibJNI.StochasticProcess_diffusion(swigCPtr, this, t, Array.getCPtr(x), x), true);
  }

  public Array expectation(double t0, Array x0, double dt) {
    return new Array(QuantLibJNI.StochasticProcess_expectation(swigCPtr, this, t0, Array.getCPtr(x0), x0, dt), true);
  }

  public Matrix stdDeviation(double t0, Array x0, double dt) {
    return new Matrix(QuantLibJNI.StochasticProcess_stdDeviation(swigCPtr, this, t0, Array.getCPtr(x0), x0, dt), true);
  }

  public Matrix covariance(double t0, Array x0, double dt) {
    return new Matrix(QuantLibJNI.StochasticProcess_covariance(swigCPtr, this, t0, Array.getCPtr(x0), x0, dt), true);
  }

  public Array evolve(double t0, Array x0, double dt, Array dw) {
    return new Array(QuantLibJNI.StochasticProcess_evolve(swigCPtr, this, t0, Array.getCPtr(x0), x0, dt, Array.getCPtr(dw), dw), true);
  }

}